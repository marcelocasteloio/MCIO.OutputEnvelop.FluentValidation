using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Engines;
using FluentValidation;
using FluentValidation.Results;
using MCIO.OutputEnvelop.FluentValidation.Benchmarks.Interfaces;

namespace MCIO.OutputEnvelop.FluentValidation.Benchmarks.ExtensionMethodsBenchs;

[SimpleJob(RunStrategy.Throughput, launchCount: 1)]
[HardwareCounters(
    HardwareCounter.CacheMisses,
    HardwareCounter.Timer,
    HardwareCounter.TotalCycles,
    HardwareCounter.TotalIssues,
    HardwareCounter.BranchMispredictions,
    HardwareCounter.BranchInstructions
)]
[MemoryDiagnoser]
public class ExtensionMethodsBenchmark
    : IBenchmark
{
    // Fields
    private static readonly Customer.RegisterNewCustomerInput _validRegisterNewCustomerInput = new(
        Id: 10,
        Name: "marcelo castelo io",
        BirthDate: DateOnly.FromDateTime(DateTime.Now.AddYears(-20))
    );
    private static readonly Customer.RegisterNewCustomerInput _invalidRegisterNewCustomerInput = new(
        Id: 0,
        Name: "marcelo",
        BirthDate: DateOnly.FromDateTime(DateTime.Now)
    );

    // Public Methods
    [Benchmark(Baseline = true, Description = "ValidationResult From Valid Input")]
    public ValidationResult ValidationResult_From_Valid_Input()
    {
        return Customer.RegisterNewWithoutOutputEnvelop(
            _validRegisterNewCustomerInput, 
            out Customer? customer
        );
    }
    [Benchmark(Description = "OutputEnvelop From Valid Input")]
    public OutputEnvelop OutputEnvelop_From_Valid_Input()
    {
        return Customer.RegisterNewWithoutOutputEnvelop(
            _validRegisterNewCustomerInput, 
            out Customer? customer
        ).ToOutputEnvelop();
    }
    [Benchmark(Description = "ValidationResult From Invalid Input")]
    public ValidationResult ValidationResult_From_Invalid_Input()
    {
        return Customer.RegisterNewWithoutOutputEnvelop(
            _invalidRegisterNewCustomerInput, 
            out Customer? customer
        );
    }
    [Benchmark(Description = "OutputEnvelop From Invalid Input")]
    public OutputEnvelop OutputEnvelop_From_Invalid_Input()
    {
        return Customer.RegisterNewWithoutOutputEnvelop(
            _invalidRegisterNewCustomerInput, 
            out Customer? customer
        ).ToOutputEnvelop();
    }

    public class Customer
    {
        // Fields
        private static RegisterNewCustomerInputValidator _registerNewCustomerInputValidator = new();

        // Properties
        public int Id { get; }
        public string Name { get; }
        public DateOnly BirthDate { get; }

        // Constructors
        private Customer(int id, string name, DateOnly birthDate)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
        }

        // Public Methods
        public static ValidationResult RegisterNewWithoutOutputEnvelop(RegisterNewCustomerInput input, out Customer? customer)
        {
            // Validation
            var validationResult = _registerNewCustomerInputValidator.Validate(input);
            if (!validationResult.IsValid)
            {
                customer = null;
                return validationResult;
            }

            // Process and return
            customer = new Customer(id: input.Id, name: input.Name, birthDate: input.BirthDate);
            return validationResult;
        }

        // Inputs
        public record RegisterNewCustomerInput(int Id, string Name, DateOnly BirthDate);

        public class RegisterNewCustomerInputValidator
            : AbstractValidator<RegisterNewCustomerInput>
        {
            // Constants
            public const string CUSTOMER_ID_IS_REQUIRED_MESSAGE_CODE = "CUSTOMER_ID_IS_REQUIRED";
            public const string CUSTOMER_ID_IS_REQUIRED_MESSAGE_DESCRIPTION = "Id is required";
            public const Severity CUSTOMER_ID_IS_REQUIRED_MESSAGE_SEVERITY = Severity.Error;

            public const string CUSTOMER_NAME_IS_REQUIRED_MESSAGE_CODE = "CUSTOMER_NAME_IS_REQUIRED";
            public const string CUSTOMER_NAME_IS_REQUIRED_MESSAGE_DESCRIPTION = "Name is required";
            public const Severity CUSTOMER_NAME_IS_REQUIRED_MESSAGE_SEVERITY = Severity.Error;

            public const string CUSTOMER_NAME_SHOULD_HAVE_LAST_NAME_MESSAGE_CODE = "CUSTOMER_NAME_SHOULD_HAVE_LAST_NAME";
            public const string CUSTOMER_NAME_SHOULD_HAVE_LAST_NAME_MESSAGE_DESCRIPTION = "Name should have last name";
            public const Severity CUSTOMER_NAME_SHOULD_HAVE_LAST_NAME_MESSAGE_SEVERITY = Severity.Warning;

            public const string CUSTOMER_BIRTHDATE_IS_REQUIRED_MESSAGE_CODE = "CUSTOMER_BIRTHDATE_IS_REQUIRED";
            public const string CUSTOMER_BIRTHDATE_IS_REQUIRED_MESSAGE_DESCRIPTION = "BirthDate is required";
            public const Severity CUSTOMER_BIRTHDATE_IS_REQUIRED_MESSAGE_SEVERITY = Severity.Error;

            public const string CUSTOMER_BIRTHDATE_SHOULD_HAVE_MAX_LENGTH_MESSAGE_CODE = "CUSTOMER_BIRTHDATE_SHOULD_HAVE_MAX_LENGTH";
            public const string CUSTOMER_BIRTHDATE_SHOULD_HAVE_MAX_LENGTH_MESSAGE_DESCRIPTION = "BirthDate is required";
            public const Severity CUSTOMER_BIRTHDATE_SHOULD_HAVE_MAX_LENGTH_MESSAGE_SEVERITY = Severity.Error;

            public const string CUSTOMER_BIRTHDATE_DAY_MESSAGE_CODE = "CUSTOMER_BIRTHDATE_DAY";
            public const string CUSTOMER_BIRTHDATE_DAY_MESSAGE_DESCRIPTION = "Today is the customer birthday";
            public const Severity CUSTOMER_BIRTHDATE_DAY_MESSAGE_SEVERITY = Severity.Info;

            // Public Methods
            public RegisterNewCustomerInputValidator()
            {
                RuleFor(p => p.Id)
                    .GreaterThan(0)
                    .WithErrorCode(CUSTOMER_ID_IS_REQUIRED_MESSAGE_CODE)
                    .WithMessage(CUSTOMER_ID_IS_REQUIRED_MESSAGE_DESCRIPTION)
                    .WithSeverity(CUSTOMER_ID_IS_REQUIRED_MESSAGE_SEVERITY);

                RuleFor(p => p.Name)
                    .NotEmpty()
                    .WithErrorCode(CUSTOMER_NAME_IS_REQUIRED_MESSAGE_CODE)
                    .WithMessage(CUSTOMER_NAME_IS_REQUIRED_MESSAGE_DESCRIPTION)
                    .WithSeverity(CUSTOMER_NAME_IS_REQUIRED_MESSAGE_SEVERITY);

                RuleFor(p => p.Name)
                    .MaximumLength(150)
                    .WithErrorCode("CUSTOMER_NAME_SHOULD_HAVE_MAX_LENGTH")
                    .WithMessage("Name should less than or equais 150 characters")
                    .WithSeverity(Severity.Error);

                RuleFor(p => p.Name)
                    .Must(name => name.Contains(" "))
                    .WithErrorCode(CUSTOMER_NAME_SHOULD_HAVE_LAST_NAME_MESSAGE_CODE)
                    .WithMessage(CUSTOMER_NAME_SHOULD_HAVE_LAST_NAME_MESSAGE_DESCRIPTION)
                    .WithSeverity(CUSTOMER_NAME_SHOULD_HAVE_LAST_NAME_MESSAGE_SEVERITY);

                RuleFor(p => p.BirthDate)
                    .NotEmpty()
                    .WithErrorCode(CUSTOMER_BIRTHDATE_IS_REQUIRED_MESSAGE_CODE)
                    .WithMessage(CUSTOMER_BIRTHDATE_IS_REQUIRED_MESSAGE_DESCRIPTION)
                    .WithSeverity(CUSTOMER_BIRTHDATE_IS_REQUIRED_MESSAGE_SEVERITY);

                RuleFor(p => p.BirthDate)
                    .LessThanOrEqualTo(DateOnly.FromDateTime(DateTime.Now))
                    .WithErrorCode(CUSTOMER_BIRTHDATE_SHOULD_HAVE_MAX_LENGTH_MESSAGE_CODE)
                    .WithMessage(CUSTOMER_BIRTHDATE_SHOULD_HAVE_MAX_LENGTH_MESSAGE_DESCRIPTION)
                    .WithSeverity(CUSTOMER_BIRTHDATE_SHOULD_HAVE_MAX_LENGTH_MESSAGE_SEVERITY);

                RuleFor(p => p.BirthDate)
                    .Must(q => q != DateOnly.FromDateTime(DateTime.Now))
                    .WithErrorCode(CUSTOMER_BIRTHDATE_DAY_MESSAGE_CODE)
                    .WithMessage(CUSTOMER_BIRTHDATE_DAY_MESSAGE_DESCRIPTION)
                    .WithSeverity(CUSTOMER_BIRTHDATE_DAY_MESSAGE_SEVERITY);
            }
        }
    }
}

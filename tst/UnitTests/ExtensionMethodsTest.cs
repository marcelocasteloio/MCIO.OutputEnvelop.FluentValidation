using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;

namespace MCIO.OutputEnvelop.FluentValidation.UnitTests;

public class ExtensionMethodsTest
{
    [Fact]
    public void ValidationResult_Should_ConvertedToOutputEnvelop_FromValidValidationResult()
    {
        // Arrange
        var registerNewCustomerInput = new Customer.RegisterNewCustomerInput(
            Id: 10, 
            Name: "marcelo castelo io", 
            BirthDate: DateOnly.FromDateTime(DateTime.Now.AddYears(-20))
        );

        // Act
        var registerNewCustomerOutputEnvelop = Customer.RegisterNew(registerNewCustomerInput, out ValidationResult validationResult);
        var outputEnvelop = validationResult.ToOutputEnvelop();

        // Assert
        registerNewCustomerOutputEnvelop.Output.Should().NotBeNull();
        registerNewCustomerOutputEnvelop.Type.Should().Be(Enums.OutputEnvelopType.Success);
        registerNewCustomerOutputEnvelop.ExceptionCollection.Should().BeEmpty();
        registerNewCustomerOutputEnvelop.OutputMessageCollection.Should().BeEmpty();

        outputEnvelop.Type.Should().Be(Enums.OutputEnvelopType.Success);
        outputEnvelop.ExceptionCollection.Should().BeEmpty();
        outputEnvelop.OutputMessageCollection.Should().BeEmpty();
    }

    [Fact]
    public void ValidationResult_Should_ConvertedToOutputEnvelop_FromInvalidValidationResult()
    {
        // Arrange
        var registerNewCustomerInput = new Customer.RegisterNewCustomerInput(
            Id: 0,
            Name: "marcelo",
            BirthDate: DateOnly.FromDateTime(DateTime.Now)
        );

        // Act
        var registerNewCustomerOutputEnvelop = Customer.RegisterNew(registerNewCustomerInput, out ValidationResult validationResult);
        var outputEnvelop = validationResult.ToOutputEnvelop();

        // Assert
        registerNewCustomerOutputEnvelop.Output.Should().BeNull();
        registerNewCustomerOutputEnvelop.Type.Should().Be(Enums.OutputEnvelopType.Error);
        registerNewCustomerOutputEnvelop.ExceptionCollection.Should().BeEmpty();
        registerNewCustomerOutputEnvelop.OutputMessageCollection.Should().HaveCount(3);

        outputEnvelop.Type.Should().Be(Enums.OutputEnvelopType.Error);
        outputEnvelop.ExceptionCollection.Should().BeEmpty();
        outputEnvelop.OutputMessageCollection.Should().HaveCount(3);

        var idIsRequiredOutputMessage = registerNewCustomerOutputEnvelop.OutputMessageCollection.First(q => 
            q.Code == Customer.RegisterNewCustomerInputValidator.CUSTOMER_ID_IS_REQUIRED_MESSAGE_CODE
        );
        var nameShouldHaveLastNameOutputMessage = registerNewCustomerOutputEnvelop.OutputMessageCollection.First(q =>
            q.Code == Customer.RegisterNewCustomerInputValidator.CUSTOMER_NAME_SHOULD_HAVE_LAST_NAME_MESSAGE_CODE
        );
        var birthDateDayOutputMessage = registerNewCustomerOutputEnvelop.OutputMessageCollection.First(q =>
            q.Code == Customer.RegisterNewCustomerInputValidator.CUSTOMER_BIRTHDATE_DAY_MESSAGE_CODE
        );

        idIsRequiredOutputMessage.Type.Should().Be(Enums.OutputMessageType.Error);
        idIsRequiredOutputMessage.Description.Should().Be(Customer.RegisterNewCustomerInputValidator.CUSTOMER_ID_IS_REQUIRED_MESSAGE_DESCRIPTION);

        nameShouldHaveLastNameOutputMessage.Type.Should().Be(Enums.OutputMessageType.Warning);
        nameShouldHaveLastNameOutputMessage.Description.Should().Be(Customer.RegisterNewCustomerInputValidator.CUSTOMER_NAME_SHOULD_HAVE_LAST_NAME_MESSAGE_DESCRIPTION);

        birthDateDayOutputMessage.Type.Should().Be(Enums.OutputMessageType.Information);
        birthDateDayOutputMessage.Description.Should().Be(Customer.RegisterNewCustomerInputValidator.CUSTOMER_BIRTHDATE_DAY_MESSAGE_DESCRIPTION);
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
        // Validation result is a out variable for test reasons
        public static OutputEnvelop<Customer> RegisterNew(RegisterNewCustomerInput input, out ValidationResult validationResult)
        {
            // Validation
            validationResult = _registerNewCustomerInputValidator.Validate(input);
            if (!validationResult.IsValid)
                return validationResult.ToOutputEnvelop<Customer>(output: null!);

            // Process and return
            return validationResult.ToOutputEnvelop(
                output: validationResult.IsValid ? new Customer(id: input.Id, name: input.Name, birthDate: input.BirthDate) : null!
            );
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

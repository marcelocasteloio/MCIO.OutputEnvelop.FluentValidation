# MCIO.OutputEnvelop.FluentValidation

Uma extensão do pacote [MarceloCastelo.IO.OutputEnvelop](https://www.nuget.org/packages/MarceloCastelo.IO.OutputEnvelop/) que integra com o pacote [FluentValidation](https://www.nuget.org/packages/FluentValidation).

## :package: Pacotes

| Nome | Versão | Link | Repository |
| :- | :- | :- | :- |
| MarceloCastelo.IO.OutputEnvelop |  ![Nuget](https://img.shields.io/nuget/v/MarceloCastelo.IO.OutputEnvelop) | [Nuget.org](https://www.nuget.org/packages/MarceloCastelo.IO.OutputEnvelop/) | [Link](https://github.com/marcelocasteloio/MCIO.OutputEnvelop/) |
| MarceloCastelo.IO.OutputEnvelop.FluentValidation |  ![Nuget](https://img.shields.io/nuget/v/MarceloCastelo.IO.OutputEnvelop.FluentValidation) | [Nuget.org](https://www.nuget.org/packages/MarceloCastelo.IO.OutputEnvelop.FluentValidation/) | Esse aqui :) |


## :label: Labels

| Categoria | Descrição | Labels (todos os ícones são clicáveis e levam as ferramentas externas) |
|-|-|-|
| Licença | MIT | [![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/) |
| Segurança | Vulnerabilidades | [![CodeQL](https://github.com/marcelocasteloio/MCIO.OutputEnvelop.FluentValidation/actions/workflows/github-code-scanning/codeql/badge.svg)](https://github.com/marcelocasteloio/MCIO.OutputEnvelop.FluentValidation/actions/workflows/github-code-scanning/codeql) [![Vulnerabilities](https://sonarcloud.io/api/project_badges/measure?project=marcelocasteloio_MCIO.OutputEnvelop.FluentValidation&metric=vulnerabilities)](https://sonarcloud.io/summary/new_code?id=marcelocasteloio_MCIO.OutputEnvelop.FluentValidation) [![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=marcelocasteloio_MCIO.OutputEnvelop.FluentValidation&metric=security_rating)](https://sonarcloud.io/summary/new_code?id=marcelocasteloio_MCIO.OutputEnvelop.FluentValidation) |
| Qualidade | Visão geral | [![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=marcelocasteloio_MCIO.OutputEnvelop.FluentValidation&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=marcelocasteloio_MCIO.OutputEnvelop.FluentValidation) |
| Qualidade | Cobertura de testes | [![Coverage](https://sonarcloud.io/api/project_badges/measure?project=marcelocasteloio_MCIO.OutputEnvelop.FluentValidation&metric=coverage)](https://sonarcloud.io/summary/new_code?id=marcelocasteloio_MCIO.OutputEnvelop.FluentValidation) |
| Qualidade | Teste de mutação | [![Mutation Test](https://github.com/marcelocasteloio/MCIO.OutputEnvelop.FluentValidation/actions/workflows/mutation-test.yml/badge.svg)](https://github.com/marcelocasteloio/MCIO.OutputEnvelop.FluentValidation/actions/workflows/mutation-test.yml) |
| Qualidade | Manutenabilidade | [![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=marcelocasteloio_MCIO.OutputEnvelop.FluentValidation&metric=sqale_rating)](https://sonarcloud.io/summary/new_code?id=marcelocasteloio_MCIO.OutputEnvelop.FluentValidation) |
| Qualidade | Confiabilidade | [![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=marcelocasteloio_MCIO.OutputEnvelop.FluentValidation&metric=reliability_rating)](https://sonarcloud.io/summary/new_code?id=marcelocasteloio_MCIO.OutputEnvelop.FluentValidation) |
| Qualidade | Bugs | [![Bugs](https://sonarcloud.io/api/project_badges/measure?project=marcelocasteloio_MCIO.OutputEnvelop.FluentValidation&metric=bugs)](https://sonarcloud.io/summary/new_code?id=marcelocasteloio_MCIO.OutputEnvelop.FluentValidation) |
| Qualidade | Dívidas técnicas | [![Technical Debt](https://sonarcloud.io/api/project_badges/measure?project=marcelocasteloio_MCIO.OutputEnvelop.FluentValidation&metric=sqale_index)](https://sonarcloud.io/summary/new_code?id=marcelocasteloio_MCIO.OutputEnvelop.FluentValidation) |
| Qualidade | Linhas duplicadas (%) | [![Duplicated Lines (%)](https://sonarcloud.io/api/project_badges/measure?project=marcelocasteloio_MCIO.OutputEnvelop.FluentValidation&metric=duplicated_lines_density)](https://sonarcloud.io/summary/new_code?id=marcelocasteloio_MCIO.OutputEnvelop.FluentValidation) |
| Qualidade | Melhorias de código | [![Code Smells](https://sonarcloud.io/api/project_badges/measure?project=marcelocasteloio_MCIO.OutputEnvelop.FluentValidation&metric=code_smells)](https://sonarcloud.io/summary/new_code?id=marcelocasteloio_MCIO.OutputEnvelop.FluentValidation) |
| Pipeline | Compilação e testes | [![Build and Test](https://github.com/marcelocasteloio/MCIO.OutputEnvelop.FluentValidation/actions/workflows/build-and-test.yml/badge.svg)](https://github.com/marcelocasteloio/MCIO.OutputEnvelop.FluentValidation/actions/workflows/build-and-test.yml) |
| Pipeline | Publicação | [![Publish](https://github.com/marcelocasteloio/MCIO.OutputEnvelop.FluentValidation/actions/workflows/publish.yml/badge.svg)](https://github.com/marcelocasteloio/MCIO.OutputEnvelop.FluentValidation/actions/workflows/publish.yml) |

## :page_facing_up: Introdução

O pacote [FluentValidation](https://www.nuget.org/packages/FluentValidation) é amplamente utilizado em projetos .NET devido à sua robustez e flexibilidade, especialmente em validações de domínio. O pacote [MarceloCastelo.IO.OutputEnvelop](https://www.nuget.org/packages/MarceloCastelo.IO.OutputEnvelop/) pode ser utilizado no lugar do FluentValidation. No entanto, é importante que eles possam funcionar lado a lado para proporcionar maior flexibilidade no projeto. Este pacote realiza a integração necessária para que possam coexistir harmoniosamente.

## :book: Conteúdo
- [MCIO.OutputEnvelop.FluentValidation](#mciooutputenvelopfluentvalidation)
  - [:package: Pacotes](#package-pacotes)
  - [:label: Labels](#label-labels)
  - [:page\_facing\_up: Introdução](#page_facing_up-introdução)
  - [:book: Conteúdo](#book-conteúdo)
  - [:package: Dependências](#package-dependências)
  - [:books: Utilização básica](#books-utilização-básica)
  - [:books: Exemplo completo](#books-exemplo-completo)
  - [:people\_holding\_hands: Contribuindo](#people_holding_hands-contribuindo)
  - [:people\_holding\_hands: Autores](#people_holding_hands-autores)

## :package: Dependências

- [.NET Standard 2.0](https://learn.microsoft.com/pt-br/dotnet/standard/net-standard?tabs=net-standard-2-0).
- Pacote [FluentValidation](https://www.nuget.org/packages/FluentValidation).

## :books: Utilização básica

- Sem objeto de retorno
```csharp
using MCIO.OutputEnvelop;

var validationResult = someValidator.Validate(input);
var outputEnvelop = validationResult.ToOutputEnvelop();
```

- Com objeto de retorno
```csharp
using MCIO.OutputEnvelop;

var customer = new Customer();
var validationResult = someValidator.Validate(input);
var outputEnvelop = validationResult.ToOutputEnvelop(customer);
```

## :books: Exemplo completo

```csharp
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
```

## :people_holding_hands: Contribuindo

[voltar ao topo](#book-conteúdo)

Você está mais que convidado para constribuir. Caso tenha interesse e queira participar do projeto, não deixe de ver nosso [manual de contribuição](docs/CONTRIBUTING-PT.md). 

## :people_holding_hands: Autores

[voltar ao topo](#book-conteúdo)

- Marcelo Castelo Branco - [@MarceloCas](https://www.linkedin.com/in/marcelocastelobranco/)
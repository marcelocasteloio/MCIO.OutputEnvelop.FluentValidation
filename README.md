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
  - [:rocket: Executando localmente](#rocket-executando-localmente)
  - [:rocket: Benchmark](#rocket-benchmark)
  - [:people\_holding\_hands: Contribuindo](#people_holding_hands-contribuindo)
  - [:people\_holding\_hands: Autores](#people_holding_hands-autores)

## :package: Dependências

[voltar ao topo](#book-conteúdo)

- [.NET Standard 2.0](https://learn.microsoft.com/pt-br/dotnet/standard/net-standard?tabs=net-standard-2-0).
- Pacote [FluentValidation](https://www.nuget.org/packages/FluentValidation).

## :books: Utilização básica

[voltar ao topo](#book-conteúdo)

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

[voltar ao topo](#book-conteúdo)

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

## :rocket: Executando localmente

[voltar ao topo](#book-conteúdo)

Por se tratar de um pacote nuget, não existe uma execução. Porém, existe o script [build-local-script](build-local-script.ps1) que pode ser executado via PowerShell que realizará as seguintes ações:

1. Instalará a CLI do ReportGenerator localmente para visualização do relatório de cobertura no formato opencover.
2. Instalará a CLI do Stryker localmente para execução e visualização do relatório do teste de mutação.
3. Restore do projeto.
4. Build do projeto em modo release.
5. Execução dos testes de unidade.
6. Execução do teste de mutação.
7. Abertura do relatório de cobertura no navegador web padrão.
8. Abertura do relatório de teste mutante no navegador web padrão.

A partir do `diretóio raiz` do repositório, no `PowerShell`, execute o comando `.\build-local-script.ps1`.

Caso queira limpar todos os arquivos gerados, a partir do `diretóio raiz` do repositório, no `PowerShell`, execute o comando `.\clear-local-script.ps1`.

## :rocket: Benchmark

[voltar ao topo](#book-conteúdo)

O benchmark abaixo (arquivo [ExtensionMethodsBenchmark.cs](benchs/Benchmarks/ExtensionMethodsBenchs/ExtensionMethodsBenchmark.cs)) compara a utilização do objeto ValidationResult como retorno do método e gerando um OutputEnvelop a partir do ValidationResult gerado.

```pwsh
// * Summary *

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22631.2861/23H2/2023Update/SunValley3)
AMD Ryzen 5 5600X, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  Job-BHOBUW : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

LaunchCount=1  RunStrategy=Throughput
```

| Method                                | Mean     | Error     | StdDev    | Ratio | RatioSD | TotalCycles/Op | CacheMisses/Op | BranchInstructions/Op | TotalIssues/Op | BranchMispredictions/Op | Timer/Op | Gen0   | Allocated | Alloc Ratio |
|-------------------------------------- |---------:|----------:|----------:|------:|--------:|---------------:|---------------:|----------------------:|---------------:|------------------------:|---------:|-------:|----------:|------------:|
| 'ValidationResult From Valid Input'   | 2.126 us | 0.0149 us | 0.0140 us |  1.00 |    0.00 |          4,955 |             10 |                 1,754 |          7,701 |                       7 |       21 | 0.0381 |     664 B |        1.00 |
| 'OutputEnvelop From Valid Input'      | 2.142 us | 0.0094 us | 0.0088 us |  1.01 |    0.01 |          4,969 |             11 |                 1,775 |          7,748 |                       7 |       22 | 0.0381 |     664 B |        1.00 |
| 'ValidationResult From Invalid Input' | 3.951 us | 0.0223 us | 0.0198 us |  1.86 |    0.02 |          9,076 |             29 |                 3,289 |         14,827 |                      16 |       40 | 0.1297 |    2224 B |        3.35 |
| 'OutputEnvelop From Invalid Input'    | 4.048 us | 0.0152 us | 0.0127 us |  1.90 |    0.01 |          9,332 |             30 |                 3,410 |         15,154 |                      17 |       41 | 0.1373 |    2320 B |        3.49 |

```pwsh
// * Hints *
Outliers
  ExtensionMethodsBenchmark.'OutputEnvelop From Valid Input': LaunchCount=1, RunStrategy=Throughput      -> 1 outlier  was  detected (2.12 us)
  ExtensionMethodsBenchmark.'ValidationResult From Invalid Input': LaunchCount=1, RunStrategy=Throughput -> 1 outlier  was  removed (4.01 us)
  ExtensionMethodsBenchmark.'OutputEnvelop From Invalid Input': LaunchCount=1, RunStrategy=Throughput    -> 2 outliers were removed (4.16 us, 4.19 us)
```

## :people_holding_hands: Contribuindo

[voltar ao topo](#book-conteúdo)

Você está mais que convidado para constribuir. Caso tenha interesse e queira participar do projeto, não deixe de ver nosso [manual de contribuição](docs/CONTRIBUTING-PT.md). 

## :people_holding_hands: Autores

[voltar ao topo](#book-conteúdo)

- Marcelo Castelo Branco - [@MarceloCas](https://www.linkedin.com/in/marcelocastelobranco/)
using FluentValidation.Results;
using FluentValidation;
using MCIO.OutputEnvelop.Enums;
using MCIO.OutputEnvelop.Models;

// The namespace MCIO.OutputEnvelop has choiced to be easy to integrate OutputEnvelop object
namespace MCIO.OutputEnvelop
{
    public static class ExtensionMethods
    {
        // Public Methods
        public static OutputEnvelop ToOutputEnvelop(this ValidationResult validationResult)
        {
            return validationResult.ToOutputEnvelopInternal();
        }
        public static OutputEnvelop<TOutput> ToOutputEnvelop<TOutput>(this ValidationResult validationResult, TOutput output)
        {
            return validationResult.ToOutputEnvelopInternal(output);
        }

        // Internal Methods
        internal static OutputEnvelop ToOutputEnvelopInternal(this ValidationResult validationResult)
        {
            var outputMessageCollection = CreateOutputMessageCollectionFromValidationResult(validationResult, out bool hasMessage);

            return OutputEnvelop.Create(
                type: GetOutputEnvelopType(validationResult),
                // The library prevent null reference
                // Stryker disable once all
                outputMessageCollection: hasMessage ? outputMessageCollection : null,
                exceptionCollection: null
            );
        }
        internal static OutputEnvelop<TOutput> ToOutputEnvelopInternal<TOutput>(this ValidationResult validationResult, TOutput output)
        {
            var outputMessageCollection = CreateOutputMessageCollectionFromValidationResult(validationResult, out bool hasMessage);

            return OutputEnvelop<TOutput>.Create(
                output,
                type: GetOutputEnvelopType(validationResult),
                outputMessageCollection: hasMessage ? outputMessageCollection : null,
                exceptionCollection: null
            );
        }

        // Private Methods
        private static OutputMessage[] CreateOutputMessageCollectionFromValidationResult(ValidationResult validationResult, out bool hasMessage)
        {
            OutputMessage[] outputMessageCollection = null;

            // The library prevent null reference
            // Stryker disable once all
            hasMessage = validationResult.Errors.Count > 0;

            if (hasMessage)
            {
                outputMessageCollection = new OutputMessage[validationResult.Errors.Count];

                for (int i = 0; i < validationResult.Errors.Count; i++)
                {
                    var error = validationResult.Errors[i];

                    outputMessageCollection[i] = OutputMessage.Create(
                        type: GetOutputMessageType(error.Severity),
                        code: error.ErrorCode,
                        description: error.ErrorMessage
                    );
                }
            }

            return outputMessageCollection;
        }
        private static OutputEnvelopType GetOutputEnvelopType(ValidationResult validationResult)
        {
            // The library prevent null reference
            // Stryker disable once all
            var hasError = false;

            foreach (var error in validationResult.Errors)
                // The library prevent null reference
                // Stryker disable once all
                if (error.Severity == Severity.Error)
                {
                    hasError = true;

                    // The library prevent null reference
                    // Stryker disable once all
                    break;
                }

            return hasError ? OutputEnvelopType.Error : OutputEnvelopType.Success;
        }
        private static OutputMessageType GetOutputMessageType(Severity severity)
        {
            if (severity == Severity.Info)
                return OutputMessageType.Information;
            else if (severity == Severity.Warning)
                return OutputMessageType.Warning;
            else
                return OutputMessageType.Error;
        }
    }
}

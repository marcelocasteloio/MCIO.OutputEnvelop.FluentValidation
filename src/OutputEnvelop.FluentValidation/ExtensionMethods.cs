using FluentValidation;
using FluentValidation.Results;
using MCIO.OutputEnvelop.Enums;
using MCIO.OutputEnvelop.Models;

namespace MCIO.OutputEnvelop.FluentValidation
{
    public static class ExtensionMethods
    {
        // Public Methods
        public static OutputEnvelop ToOutputEnvelop(this ValidationResult validationResult)
        {
            return validationResult.ToOutputEnvelopInternal();
        }

        // Internal Methods
        internal static OutputEnvelop ToOutputEnvelopInternal(this ValidationResult validationResult)
        {
            var hasMessage = validationResult.Errors.Count > 0;
            OutputMessage[] outputMessageCollection = null;

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

            return OutputEnvelop.Create(
                type: GetOutputEnvelopType(validationResult),
                outputMessageCollection: hasMessage ? outputMessageCollection : null,
                exceptionCollection: null
            );
        }

        // Private Methods
        private static OutputEnvelopType GetOutputEnvelopType(ValidationResult validationResult)
        {
            if (validationResult.IsValid)
                return OutputEnvelopType.Success;

            var hasError = false;

            foreach (var error in validationResult.Errors)
                if (error.Severity == Severity.Error)
                {
                    hasError = true;
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

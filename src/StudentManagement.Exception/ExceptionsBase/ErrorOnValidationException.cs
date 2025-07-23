namespace StudentManagement.Exception.ExceptionsBase
{
    public class ErrorOnValidationException : StudentManagementException
    {
        public List<string> Errors { get; set; }

        public ErrorOnValidationException(List<string> errorMessages)
        {
            this.Errors = errorMessages;
        }
    }
}

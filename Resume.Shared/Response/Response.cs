namespace Resume.Shared.Response
{
    public class Response
    {
        public bool IsSuccessful { get; set; }
        public List<string> Errors { get; set; } = new List<string>();

        public Response(bool success) => IsSuccessful = success;
        public static Response Success => new(true);
        public Response(List<string> errors)
        {
            Errors = errors;
            IsSuccessful = false;
        }
        public Response(params string[] errors)
        {
            Errors = errors.ToList();
            IsSuccessful = false;
        }
    }

    public class Response<T> : Response where T : new()
    {
        public T? Result { get; set; } = default;
        public Response(T? result)
        {
            Result = result;
            IsSuccessful = true;
        }
        public Response(List<string> errors) : base(errors) { }
        public Response(params string[] errors) : base(errors) { }
    }
}

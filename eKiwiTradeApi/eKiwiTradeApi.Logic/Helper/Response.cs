namespace eKiwiTradeApi.Logic.Helper
{
    public class Response<T>
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }

        public T Data { get; set; }
        public List<T> Datas { get; set; }
    }

}

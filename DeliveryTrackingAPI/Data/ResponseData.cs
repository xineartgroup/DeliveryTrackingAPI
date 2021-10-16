namespace DeliveryTrackingAPI.Data
{
    public class ResponseData
    {
        public ResponseData()
        {
            ResponseCode = string.Empty;
            ResponseDescription = string.Empty;
        }
        
        public ResponseData(string code, string discription)
        {
            ResponseCode = code;
            ResponseDescription = discription;
        }

        public string ResponseCode { get; set; } = string.Empty;

        public string ResponseDescription { get; set; } = string.Empty;
    }
}

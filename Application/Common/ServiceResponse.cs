using System.Windows.Markup;

namespace Application.Common
{
    public class ServiceResponse<T>
    {
        public bool Status { get; set; }
        public string ResponseMessage { get; set; }
        public List<T> Values { get; set; } = new List<T>();
       
        public ServiceResponse(bool status,string responseMessage )
        {
            Status = status;
            ResponseMessage = responseMessage;    
        }

        public ServiceResponse(bool status, string responseMessage,List<T> values):this(status,responseMessage) 
        {
           Values = values;
        }

        public ServiceResponse(bool status, string responseMessage, T value) : this(status, responseMessage)
        {
            if (value is null) {
                throw new ArgumentException($"the value of {nameof(value)} cannont be null");
                
            }
            Values.Add(value);
        }





    }
}


namespace DevOps_Awarness.Models
{
    public class DevOpsResponse
    {
        public string Message { get; set; }

        public DevOpsResponse(string message)
        {
            Message = message;
        }
    }
}
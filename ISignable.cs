using System.Windows.Forms;

namespace HMI_Lab3
{
    
    public interface ISignable
    {
       
        void SignIn(string login, string password);
    }
}
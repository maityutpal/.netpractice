using MembershipManagement.FieldValidators;
using MembershipManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MembershipManagement.CommonOutputFormat;

namespace MembershipManagement.Views
{
    internal class WelcomeUserView : IView
    {
        User _user = null;

        public WelcomeUserView(User user)
        {
            _user = user;
        }
        public IFieldValidator FieldValidator => throw new NotImplementedException();

        public void RunView()
        {
            Console.Clear();
            CommonOutputText.WriteMainHeading();

            CommonOutputFormat.ChangeFontColor(FontTheme.Success);
            Console.WriteLine($"Hi {_user.FirstName}!!{Environment.NewLine}Welcome to the Cycling Club!!");
            CommonOutputFormat.ChangeFontColor(FontTheme.Default);
            Console.ReadKey();
        }
    }
}

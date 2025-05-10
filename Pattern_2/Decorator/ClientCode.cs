using Pattern_2.Decorator.ConDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_2.Decorator
{
    public class ClientCode
    {
        public void NotificationService(List<IComponent> components, string message)
        { 
            foreach (var component in components)
            {
                Console.WriteLine(component.Send(message));
            }
            Console.WriteLine();
        }
        public void Main()
        {
            IComponent mobileNotify = new MobileNotify("Samsung A50");
            IComponent webNotify = new WebNotify("Web Push Notifier");
            IComponent serverNotify = new ServerNotify("AWS Linux 45.4");

            var forMobileNotification = new List<IComponent>();
            forMobileNotification.Add(new SMSDecorator(mobileNotify));
            var forWebNotification = new List<IComponent>();
            forWebNotification.Add(new EmailDecorator(webNotify));
            forWebNotification.Add(new FacebookDecorator(webNotify));
            forMobileNotification.Add(new TwitterDecorator(webNotify));
            var forServerNotification = new List<IComponent>();
            forServerNotification.Add(new SlackDecorator(serverNotify));

            NotificationService(forMobileNotification, "Recall me please! - Bob.");
            NotificationService(forWebNotification, "Hello! I`m Bob Marly. Can I call you?");
            NotificationService(forServerNotification, "Task #1234 from Jira moved to Done.");
        }
    }
}

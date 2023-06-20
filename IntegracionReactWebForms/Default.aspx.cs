
using React;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IntegracionReactWebForms
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var env = AssemblyRegistration.Container.Resolve<IReactEnvironment>();
            var objectModel = new { user = "React User" };
            var reactComponent = env.CreateComponent("PageContent", objectModel);



            PageContent.Text = reactComponent.RenderHtml();
            
        }
    }
}
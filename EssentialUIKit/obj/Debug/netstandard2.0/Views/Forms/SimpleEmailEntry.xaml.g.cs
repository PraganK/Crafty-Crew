//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("EssentialUIKit.Views.Forms.SimpleEmailEntry.xaml", "Views/Forms/SimpleEmailEntry.xaml", typeof(global::EssentialUIKit.Views.Forms.SimpleEmailEntry))]

namespace EssentialUIKit.Views.Forms {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views\\Forms\\SimpleEmailEntry.xaml")]
    public partial class SimpleEmailEntry : global::Xamarin.Forms.ContentView {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::EssentialUIKit.Controls.BorderlessEntry EmailEntry;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Label ValidationLabel;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(SimpleEmailEntry));
            EmailEntry = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::EssentialUIKit.Controls.BorderlessEntry>(this, "EmailEntry");
            ValidationLabel = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "ValidationLabel");
        }
    }
}

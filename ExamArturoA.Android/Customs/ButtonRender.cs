using System;
using Android.Content;
using ExamArturoA.Droid.Customs;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Button), typeof(ButtonRender))]  

namespace ExamArturoA.Droid.Customs
{
    /// <summary>
    /// Render button
    /// </summary>
    public class ButtonRender : Xamarin.Forms.Platform.Android.AppCompat.ButtonRenderer
    {
        /// <summary>
        /// Const
        /// </summary>
        /// <param name="context"></param>
        public ButtonRender(Context context) : base(context)
        {
            
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
                // Cleanup
            }

            if (e.NewElement != null)
            {
                Control.SetShadowLayer(5, 3, 3, Color.Black.ToAndroid());
                Control.SetBackgroundColor(new Android.Graphics.Color(10, 250, 20, 40));
            }
        }
    }
}

using System;
using CoreGraphics;
using UIKit;

namespace TipCalculator
{
    public class MyViewController : UIViewController
    {
        public MyViewController()
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.View.BackgroundColor = UIColor.Yellow;
            UITextField totalAmount = new UITextField()
            {
                Frame = new CGRect(10, 20, View.Bounds.Width - 20, 35),
                KeyboardType = UIKeyboardType.NumberPad,
                BorderStyle = UITextBorderStyle.RoundedRect,
                Placeholder = "Enter tip amount"
            };
            View.AddSubviews(totalAmount);
        }

    }
}

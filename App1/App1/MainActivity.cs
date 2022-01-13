using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace App1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView firstText;
        TextView answerTextView;
        EditText firstNumberEditText;
        EditText secondNumberEditText;
        Button addbutton;
        Button subtractButton;
        Button multiplyButton;
        Button divideButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            //firstText = FindViewById<TextView>(Resource.Id.textView1);
            Button addButton;
           

            firstNumberEditText = FindViewById<EditText>(Resource.Id.firstNumberEditText);
            secondNumberEditText = FindViewById<EditText>(Resource.Id.secondNumberEditText);
            addButton = FindViewById<Button>(Resource.Id.addButton);
            subtractButton = FindViewById<Button>(Resource.Id.subtractButton);
            multiplyButton = FindViewById<Button>(Resource.Id.multiplyButton);
            divideButton = FindViewById<Button>(Resource.Id.divideButton);
            answerTextView = FindViewById<TextView>(Resource.Id.answerTextView);
           

            addButton.Click += AddButton_Click;
            subtractButton.Click += SubtractButton_Click;
            multiplyButton.Click += MultiplyButton_Click;
            divideButton.Click += DivideButton_Click;


        }

        private void AddButton_Click(object sender, System.EventArgs e)
            {

            var firstNumber = double.Parse(firstNumberEditText.Text);
            var secondNumber = double.Parse(secondNumberEditText.Text);
            var answer = firstNumber + secondNumber;
            answerTextView.Text = answer.ToString();
                
               
            }
        private void SubtractButton_Click(object sender, System.EventArgs e)
        {

            var firstNumber = double.Parse(firstNumberEditText.Text);
            var secondNumber = double.Parse(secondNumberEditText.Text);
            var answer = firstNumber - secondNumber;
            answerTextView.Text = answer.ToString();

           
        }

        private void MultiplyButton_Click(object sender, System.EventArgs e)
        {

            var firstNumber = double.Parse(firstNumberEditText.Text);
            var secondNumber = double.Parse(secondNumberEditText.Text);
            var answer =  firstNumber * secondNumber;
            answerTextView.Text = answer.ToString();
        }
        private void DivideButton_Click(object sender, System.EventArgs e)
        {

            var firstNumber = double.Parse(firstNumberEditText.Text);
            var secondNumber = double.Parse(secondNumberEditText.Text);
            var answer = firstNumber / secondNumber;
            answerTextView.Text = answer.ToString();
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
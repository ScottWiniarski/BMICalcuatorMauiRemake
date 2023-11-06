/*using static Android.Renderscripts.ScriptGroup;*/

namespace BMICalcuatorMauiRemake;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	public void Button_Clicked(object sender, EventArgs e)
	{
		double pounds = Convert.ToDouble(In_weight.Text);
		double height = (12 * Convert.ToDouble(In_heightFeet.Text) + (Convert.ToDouble(In_heightInches.Text)));

		Out_text.Text = "Your BMI is " + Math.Round((pounds / (height * height) * 703), 2).ToString();
	}

	void OnDateSelected(object sender, System.EventArgs e)
	{
		double UsAge = DateTime.Now.Year - birthDate.Date.Year;
		Out_Alcohol.Text = UsAge.ToString();

		if(UsAge >= 21)
		{
			Out_Alcohol.Text = "It's legal to drink in the United States.";
		}
		else if(UsAge == 0)
		{
			Out_Alcohol.Text = "You've got 21 year(s) to go.";
		}
		else
		{
			Out_Alcohol.Text = "You've got " + (DateTime.Now.Year - birthDate.Date.Year) + " year(s) to go";
		}
	}

    string input = "";
    void Dot_Clicked(object sender, System.EventArgs e)
	{
        input += '.';
        In_char.Text = input;
    }

    void Dash_Clicked(object sender, System.EventArgs e)
    {
        input += '-';
        In_char.Text = input;
    }

    void Space_Clicked(object sender, System.EventArgs e)
    {
        Out_char.Text += Morse.MorseCoder(input);
        input = "";
    }

	/*private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}*/
}


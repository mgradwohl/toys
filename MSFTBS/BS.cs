/* Implementation of the classical Black-Scholes formulae to value a European call
   option on a non-dividend stock.

Formula: C(S,t) = S*N(d1) - E*exp(-r*(T-t))*N(d2),

		 where	C(S,t): call option value (in dollars),
				S: asset price (in dollars),
				T-t: time to expiry (in months) - code uses only T,
				E: exercise price (in dollars),
				r: risk free rate (%),
				sigma: annual volatility (%),
				d1, d2: defined in terms of S, E, r, sigma, T-t (see program),
				N(*): cummulative standard normal distribution.
*/

//Preprocessor directives
#include <iostream.h>
#include <iomanip.h>
#include <math.h>

//Function prototype
double CNormal(double); //Function used to compute N(*)


int main(int argc, char* argv[])
{
	//Input variables
	double S, E, r, sigma, T;

	//Ouput variable
	double call_option_value;

	//Working variables
	double d1, d2;
	char change_response, exit_changes, quit_program;

	//Display a banner to assist user
	cout << "$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$\n";
	cout << "$  PROGRAM TO VALUE A EUROPEAN CALL OPTION ON A NON-DIVIDEND STOCK  $\n";
	cout << "$                     Developer: George Scoufis                     $\n";
	cout << "$                                                                   $\n";
	cout << "$  Inputs: Asset price (S), Exercise price (E), Risk free rate (r), $\n";
	cout << "$          Annual volatility (sigma),  Time to expiry (T)           $\n";
	cout << "$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$\n\n";	
	
	//Prompt the user to enter S, E, r, sigma and T
	cout << "Asset price: $";
	cin >> S;
	cout << "Exercise price: $";
	cin >> E;
	cout << "Risk free rate %: ";
	cin >> r;
	cout << "Annual volatitity %: ";
	cin >> sigma;
	cout << "Time to expiry (months): ";
	cin >> T;

	//Echo inputs and provide user with the opportunity to change inputs
	cout << endl << endl;
	cout << "                        INPUTS\n";
	cout << "                        ------\n\n";
	cout << "    S         E         r          sigma          T\n";
	cout << "    -         -         -          -----          -\n";
	cout << setw(5) << S << setw(10) << E
		 << setw(10) << r << setw(15) << sigma << setw(11) << T << endl << endl;
	cout << "Do you wish to change any of the inputs ? (y/n): ";
	cin >> change_response;
	if(change_response == 'y' || change_response == 'Y')
	{
		do
		{
			cout << "Enter variable (individually) to change: S, E, r, v(volatility), T: ";
			cin >> change_response;

			switch(change_response)
			{

				case 'S':
					cout << "New asset price: $";
					cin >> S;
					cout << "Continue with changes ? (y/n): ";
					cin >> exit_changes;
					cout << endl;
					break;

				case 'E':
					cout << "New exercise price: $";
					cin >> E;
					cout << "Continue with changes ? (y/n): ";
					cin >> exit_changes;
					cout << endl;
					break;

				case 'r':
					cout << "New risk free rate %: ";
					cin >> r;
					cout << "Continue with changes ? (y/n): ";
					cin >> exit_changes;
					cout << endl;
					break;

				case 'v':
					cout << "New annual volatitlity %: ";
					cin >> sigma;
					cout << "Continue with changes ? (y/n): ";
					cin >> exit_changes;
					cout << endl;
					break;

				case 'T':
					cout << "New time to expiry (months): ";
					cin >> T;
					cout << "Continue with changes ? (y/n): ";
					cin >> exit_changes;
					cout << endl;
					break;

				default:
					break;
			}

		} while(exit_changes != 'n' && exit_changes != 'N');
	}

	//Compute d1 and d2
	//d1 = (ln(S/E) + (r + 0.5*sigma^2)*(T - t))/(sigma*sqrt(T - t))
	//d2 = d1 - sigma*sqrt(T - t)
	//Notes: 1) r and sigma must be converted from % to decimal form
	//		 2) T must be converted from months to years
	r *= 0.01;
	sigma *= 0.01;
	T /= 12.0;
	d1 = (log(S/E) + (r + 0.5*pow(sigma,2))*T)/(sigma*sqrt(T));
	d2 = d1 - sigma*sqrt(T);

	//Compute and display the value of the call option
	call_option_value = S*CNormal(d1) - E*CNormal(d2)*exp(-r*T);
	cout << setiosflags(ios::fixed) << setprecision(2) << endl;
	cout << "==> Call option value: $" << call_option_value;	
	
	//Terminate program
	cout << "\n\nENTER A CHARACTER TO QUIT: ";
	cin >> quit_program;	
	
	return 0;
}

//Definition of double CNormal(double)
double CNormal(double x)
{
	//Return variable
	double ans;

	//Working variable
	double y;

	y = 1.0/(1.0 + 0.33267*fabs(x));
	ans = 1.0 - 0.3989422*exp(-0.5*pow(fabs(x),2))*
							(0.4361836*y - 0.1201676*pow(y,2) + 0.9372980*pow(y,3));
	if(x < 0.0)
		ans = 1 - ans;

	return ans;
}

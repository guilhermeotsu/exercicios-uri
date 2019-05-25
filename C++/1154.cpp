#include<iostream>
#include<iomanip>

using namespace std; 

int main(){
	
	float i = 0.0;
	int idade, sum = 0;
	
	while(cin >> idade){
		if(idade < 0) break;
			sum += idade;
			i += 1.0;
	}
	double med;
	med = (double)sum / i;
	cout << med << fixed << setprecision(2) << endl;
	return 0;
}

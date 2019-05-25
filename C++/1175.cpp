#include<iostream>
#include<iomanip>
using namespace std; 

int main(){
	
	double vetor[100];
	double n;
		
	cin >> n;
	
	for(int i = 0; i < 100;i++ ){
		vetor[i] = n;			
		cout << "N[" << i <<"] = " << fixed<<setprecision(4)<<vetor[i] <<endl;
		n /= 2;	
	}
}

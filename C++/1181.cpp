#include<iostream>
#include<iomanip>

using namespace std;

int main(){ 
	
	double M[12]12];
	double sum, med;
	int l;
	char t;
	
	cin >>l;
	cin >> t;
	
	for(int i =0; i < 12; i++){
		for(int j = 0; j < 
		5; j++){
			cin >> M[i][j]; 
			if(i == l){
				sum+=M[i][j];
			}
		}
	}
	med = sum / 3.0;
	if(t == 'S'){
		cout << sum << fixed<<setprecision(1)<<endl;
	} else{
		cout << med << fixed<<setprecision(1)<< endl;
	}
}

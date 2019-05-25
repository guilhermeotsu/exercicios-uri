#include<iostream>

using namespace std;

int main(){
	int x, sum = 0;
	
	cin >> x;
	
	while(x != 0){
		for(int i = x; i <= x + 9; i++){
			if(i % 2 == 0){			
			sum +=i;
		}
		}
		cout << sum <<endl;
		sum = 0;
		cin >>x; 
	}
}

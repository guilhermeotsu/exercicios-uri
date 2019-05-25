#include<iostream>

using namespace std; 

int main(){

int n, x; 

cin >> n;

for(int i = 1; i <= n; i++){
	x = i * i;
	cout << i << " " << x << " " << i * x << endl;
	x+=1;
	cout << i << " " << x  << " " << i * x - i + 1 << endl;
	 
}
}

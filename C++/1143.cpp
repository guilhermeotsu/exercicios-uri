#include<iostream>
#include<math.h>

using namespace std;

int main() {
	
	int n, i, x;
	
	cin >> n;
	
	for(i = 1; i <= n; i++){ 
		if(i % 2 == 0) {		
		cout << i << " " << pow(i,2) <<  " " << pow(i, 3) << endl;
	} else 
		cout << i << " " << pow(i,2) <<  " " << pow(i,3) << endl;
	}
	return 0;
}

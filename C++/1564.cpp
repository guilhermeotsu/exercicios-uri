#include<iostream>

using namespace std;

int main() { 
	int x; 
		
	while(cin >> x){
	
	if(x >= 0 && x <= 100){	
		if(x != 0) { 
			cout << "vai ter duas!" << endl;
	} 	else {
			cout << "vai ter copa!" << endl;
		}		
	}
  }
}	

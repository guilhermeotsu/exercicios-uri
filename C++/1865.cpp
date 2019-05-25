#include<iostream>


using namespace std;

int main(){
	string x; 
	int y, z;
	
	cin >> z;
	
	for(int i = 1; i <= z; i++){
		cin >> x >> y;
		
		if(x != "Thor"){
			cout << "N" << endl;
		} else {
			cout << "Y" << endl;
		}
	}
}

#include<iostream>

using namespace std;

int main() {
	
	int x, y, qtd = 0, vinter=0, vremio=0, nempa=0, opc;
	
	do {
		cin >> x >> y;
		
		if(x > y){
			vinter +=1;
		} else if (y > x) {
			vremio +=1;
		} else{
			nempa +=1;
		}
					
		qtd +=1;
		cout << "Novo grenal (1-sim 2-nao)" <<endl;
		cin >> opc;
	} while (opc == 1);
	
	cout << qtd << " grenais" <<endl 
		 << "Inter:" << vinter <<endl
		 << "Gremio:" <<vremio <<endl
		 << "Empates:" << nempa <<endl;
	if (vinter > vremio) {
		cout << "Inter venceu mais" <<endl;
	} else if (vremio > vinter) {
		cout << "Gremio venceu mais" <<endl;
	} else if (vinter == vremio) {
		cout << "Nao houve vencedor" <<endl;
	}
}


#include <iostream>
#define N_VEHICULOS 3
#define N_PRIORIDADES 3
#define N_ELEMENTOS 5


int main(void) {
	int pesoMaximo[N_VEHICULOS] = { 10,20,40 };
	int prioridadElemento[N_ELEMENTOS] = { 3,1,1,2,3 };
	float capacidadElemento[N_ELEMENTOS] = { 1,5,8,2,5 };
	int dRepartos[N_ELEMENTOS] = { 1, 2, 3, 3, 1 }; // mismo coste = mismo nodo


	float pesoOcupado[N_VEHICULOS] = { 0 };
	int cantPrioridad[N_VEHICULOS] = { 0 };
	int cantElementos[N_VEHICULOS] = { 0 };
	int idxPrioridad = 3;
	int max = 0;
	int prioritario = 0;
	for (int i = 0; i < N_ELEMENTOS; i++) {
		if (prioridadElemento[i] == idxPrioridad) {
			for (int j = 0; j < N_VEHICULOS; j++) {
				if (j == 0 || cantElementos[j] > max) {
					max = cantElementos[j];
					prioritario = j;
				}
			}

		}
		if (i == N_ELEMENTOS - 1) {
			pesoOcupado[prioritario] = 0;
			i = 0;
			idxPrioridad--;
		}
	}






























}
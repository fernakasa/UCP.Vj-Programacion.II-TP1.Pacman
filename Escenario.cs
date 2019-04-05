public class Escenario{
	private int Ancho;
	private int Alto;
	private Celda[,] Celdas;
	public void SetAncho(int ancho){
		this.Ancho = ancho;
	}
	public void SetAlto(int alto){
		this.Alto = alto;
	}
	public int GetAncho(){
		return this.Ancho;
	}
	public int GetAlto(){
		return this.Alto;
	}
	public Escenario(int ancho, int alto){
		this.Celdas = new Celda[ancho,alto];
		this.Ancho = ancho;
		this.Alto = alto;
		for (int i = 0; i < ancho; i++){
			for (int j = 0; j < alto; j++){
				var celda = new Celda(i, j);
				this.Celdas[i,j] = celda;
			}
		}
	}
	public Celda ObtenerCeldaEnPosicion(int x, int y){
		return this.Celdas[x, y];
	}
}
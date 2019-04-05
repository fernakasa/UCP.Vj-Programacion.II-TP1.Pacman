using System;
public class Pacman {
	private int Puntos;
	private int Vida;
	private Celda Posicion;
	private bool EstadoUp;
	public void SetVida(int vida){
		this.Vida = vida;
	}
	public void SetPuntos(int puntos){
		this.Puntos = puntos;
	}
	public Celda GetPosicion(){
		return this.Posicion;
	}
	public bool GetEstadoUp(){
		return this.EstadoUp;
	}
	public void SetPosicion(Celda celda){
		this.Posicion = celda;
	}
	public void SetEstadoUp(bool estado){
		this.EstadoUp = estado;
	}
	public int GetVida(){
		return this.Vida;
	}
	public int GetPuntos(){
		return this.Puntos;
	}
	public Pacman(string tipo, Celda posicion){
        this.Posicion = posicion;
        this.EstadoUp = false;
        posicion.SetOcupado(true);
		this.Vida = 100;
		this.Puntos = 0;
	}
	public void PrintEstados(){
		if (this.GetEstadoUp()){
			
		}
		Console.WriteLine($"Pacman tiene {this.GetVida()} de vida y un total de {this.GetPuntos()} puntos");
		Console.WriteLine($"Pacman se encuentra en la celda({this.GetPosicion().GetPosX()},{this.GetPosicion().GetPosY()})");
	}

	public void Mover(Celda destino){
		if (destino.GetPosX() == this.Posicion.GetPosX() && destino.GetPosY() == this.Posicion.GetPosY()){
			Console.WriteLine("Movimiento invalido, no puedes moverte hacia el mismo lugar en el que estas");
		}
		else{
			if (destino.ValidarMovimiento()){
				this.Posicion.SetEsPacman(false);
				this.SetPosicion(destino);
				if (destino.GetPieza().GetTipo() == "Puntos"){
					this.Puntos = this.Puntos + 10;
				}
				else{
					
				}
			}

		}
	}
}
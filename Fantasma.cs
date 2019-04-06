using System;
public class Fantasma{
	private bool Estado;
	private Celda Posicion;
	public void SetEstado(bool estado){
		this.Estado = estado;
	}
	public void SetPosicion(Celda posicion){
		this.Posicion = posicion;
	}
	public bool GetEstado(){
		return this.Estado;
	}
	public Celda GetPosicion(){
		return this.Posicion;
	}
	public Fantasma(Celda posicion){
		this.Posicion = posicion;
	}
	public void Mover(Celda posicion){
		this.SetPosicion(posicion);
	}
}
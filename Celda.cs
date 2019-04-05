using System;
public class Celda{
    private int PosX;
    private int PosY;
    private bool Ocupado;
    private bool EsPacman;
	private Piezas Piezas;
    public void SetPosX(int x){
        this.PosX = x;
    }
    public void SetPosY(int y){
        this.PosY = y;
    }
    public void SetOcupado(bool ocupado){
        this.Ocupado = ocupado;
    }
    public void SetEsPacman(bool esPacman){
        this.EsPacman = esPacman;
    }
    public void SetPieza(Piezas piezas){
        this.Piezas = piezas;
    }
	public int GetPosX(){
        return this.PosX;
    }
    public int GetPosY(){
        return this.PosY;
    }
    public bool GetOcupado(){
		return this.Ocupado;
    }
    public bool GetEsPacman(){
		return this.EsPacman;
    }
    public Piezas GetPieza(){
        return this.Piezas;
    }
    public Celda(int x,int y){
        this.PosX = x;
        this.PosY = y;
        this.Ocupado = false;
    }
	public bool ValidarMovimiento(){
		if (!this.GetOcupado()){
		    Console.WriteLine($"La celda({this.GetPosX()},{this.GetPosY()}) se encuentra libre");
            this.EsPacman = true;
			return true;
		}
		else{
			Console.WriteLine($"La celda ({this.GetPosX()},{this.GetPosY()}) encuentra ocupada");
			return false;
		}
	}
}
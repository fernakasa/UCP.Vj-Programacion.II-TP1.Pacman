using System;
public class Piezas{
	private string Tipo;
	public void SetTipo(String tipo){
		this.Tipo = tipo;
	}
	public string GetTipo(){
		return this.Tipo;
	}
    public Piezas(string tipo){
        this.Tipo = tipo;
    }
} 
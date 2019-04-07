using System;
public class Pacman{
    private int PowerTime;
    private bool Power = false;
    private bool Die = false;
    private string Caracter = "Ö";
    private int Pos_X = 17;
    private int Pos_Y = 26;
    private int Vida = 3;
    private int Puntos = 0;
    public void SetPowerTime(int ptime){
        this.PowerTime = ptime;
    }
    public int GetPowerTime(){
        return this.PowerTime;
    }
    public void SetPower(bool power){
        this.Power = power;
    }
    public bool GetPower(){
        return this.Power;
    }
    public void SetDie(bool die){
        this.Die = die;
    }
    public bool GetDie(){
        return this.Die;
    }
    public void SetCaracter(string caracter){
        this.Caracter = caracter;
    }
    public string GetCaracter(){
        return this.Caracter;
    }
    public void SetX(int x){
        this.Pos_X = x;
    }
    public int GetX(){
        return this.Pos_X;
    }
    public void SetY(int y){
        this.Pos_Y = y;
    }
    public int GetY(){
        return this.Pos_Y;
    }
    public void SetVida(int vida){
        this.Vida = vida;
    }
    public int GetVida(){
        return this.Vida;
    }
    public void SetPuntos(int puntos){
        this.Puntos = puntos;
    }
    public int GetPuntos(){
        return this.Puntos;
    }
    public Pacman(){
    }
    public void SetPosicion(int pos_x, int pos_y){
        this.SetX(pos_x);
        this.SetY(pos_y);
    }
    public void Move(ConsoleKeyInfo info, Escenario esc){
        if (info.Key == ConsoleKey.LeftArrow){
            this.HacerMovimiento(0,-1,esc);
        }
        else if (info.Key == ConsoleKey.RightArrow){
            this.HacerMovimiento(0,1,esc);
        }   
        else if (info.Key == ConsoleKey.UpArrow){
            this.HacerMovimiento(-1,0,esc);
        }   
        else if (info.Key == ConsoleKey.DownArrow){
            this.HacerMovimiento(1,0,esc);
        }
    }
    public void PowerTimeControl(){
        if (this.GetPower() == true){
            if (this.GetPowerTime() > 0){
                this.SetPowerTime(this.GetPowerTime() - 1);
            }
            else{
                this.SetPower(false);
            }
        }
    }
    public void Morir(Escenario esc){
        if (esc.GetVidas() > 1){
            esc.SetPosicion(this.GetX(),this.GetY()," ");
            this.SetPosicion(17, 26);
            esc.SetPosicion(this.GetX(),this.GetY(),this.GetCaracter());
            esc.SetVidas(esc.GetVidas() - 1);
        }
        else{
            this.Die = true;
        }
    }
    public void HacerMovimiento(int x, int y, Escenario esc){
        int nueva_pos_x = this.GetX() + x;
        int nueva_pos_y = this.GetY() + y;
        if(esc.QueHay(nueva_pos_x, nueva_pos_y) == " " || esc.QueHay(nueva_pos_x, nueva_pos_y) == "∙" || esc.QueHay(nueva_pos_x, nueva_pos_y) == "o" || (esc.QueHay(nueva_pos_x, nueva_pos_y) == "@" && this.Power == true)){
            if(esc.QueHay(nueva_pos_x, nueva_pos_y) == "∙"){
                esc.SetPuntos(esc.GetPuntos() + 10);
            }
            if(esc.QueHay(nueva_pos_x, nueva_pos_y) == "o"){
                esc.SetPuntos(esc.GetPuntos() + 20);
                this.SetPower(true);
                this.SetPowerTime(60);
            }
            esc.SetPosicion(this.GetX(), this.GetY(), " ");
            esc.SetPosicion(nueva_pos_x, nueva_pos_y, this.GetCaracter());
            this.SetPosicion(nueva_pos_x, nueva_pos_y);
        }
        else{
            if(esc.QueHay(nueva_pos_x, nueva_pos_y) == "@" && this.Power == false){
                this.Morir(esc);
            }
        }
    }
}

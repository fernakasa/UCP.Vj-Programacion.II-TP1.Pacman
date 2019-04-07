using System;
public class Fantasmas{
    private string CharacterAnterior = " ";
    private int Direction = 1;
    private string Caracter = "@";
    private int Pos_X = 11;
    private int Pos_Y = 26;
    public void SetCaracter(string caracter){
        this.Caracter = caracter;
    }
    public string GetCaracter(){
        return this.Caracter;
    }
    public void SetDirection(int dir){
        this.Direction = dir;
    }
    public int GetDirection(){
        return this.Direction;
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
    public void SetCharacterAnterior(string character){
        this.CharacterAnterior = character;
    }
    public string GetCharacterAnterior(){
        return this.CharacterAnterior;
    }
    public Fantasmas(){
        Random random = new Random();
        this.Direction = random.Next(1, 5);
    }
    public Fantasmas(int x, int y){
        this.SetPosicion(x, y);
    }
    public void SetPosicion(int pos_x, int pos_y){
        this.SetX(pos_x);
        this.SetY(pos_y);
    }
    public void Move(Escenario esc, Pacman pacman){
        this.TengoQueMorir(this.GetX(), this.GetY(), esc, pacman);
        pacman.PowerTimeControl();
        if (this.Direction == 1){
            this.HacerMovimiento(0,-1,esc,pacman);
        }
        else if (this.Direction == 2){
            this.HacerMovimiento(0,1,esc,pacman);
        }   
        else if (this.Direction == 3){
            this.HacerMovimiento(-1,0,esc,pacman);
        }   
        else if (this.Direction == 4){
            this.HacerMovimiento(1,0,esc,pacman);
        }
    }
    public void Morir(Escenario esc){
        this.SetCharacterAnterior(" ");
        this.SetPosicion(11, 26);
        esc.SetPosicion(this.GetX(),this.GetY(),this.GetCaracter());
    }
    public void TengoQueMorir(int x, int y, Escenario esc, Pacman pacman){
        if (esc.QueHay(x, y) == "Ö" && pacman.GetPower() == true){
            esc.SetPosicion(this.GetX(), this.GetY(), this.GetCharacterAnterior());
            this.Morir(esc);
        }
    }
    public void HacerMovimiento(int x, int y, Escenario esc, Pacman pacman){
        int nueva_pos_x = this.GetX() + x;
        int nueva_pos_y = this.GetY() + y;
        if(esc.QueHay(nueva_pos_x, nueva_pos_y) == " " || esc.QueHay(nueva_pos_x, nueva_pos_y) == "∙" || esc.QueHay(nueva_pos_x, nueva_pos_y) == "o"){
            esc.SetPosicion(this.GetX(), this.GetY(), this.GetCharacterAnterior());
            this.SetCharacterAnterior(esc.QueHay(nueva_pos_x, nueva_pos_y));
            esc.SetPosicion(nueva_pos_x, nueva_pos_y, this.GetCaracter());
            this.SetPosicion(nueva_pos_x, nueva_pos_y);
        }
        else{
            if(esc.QueHay(nueva_pos_x, nueva_pos_y) == "Ö" && pacman.GetPower() == false){
                pacman.Morir(esc);
            }
            if(esc.QueHay(nueva_pos_x, nueva_pos_y) == "Ö" && pacman.GetPower() == true){
                this.TengoQueMorir(nueva_pos_x, nueva_pos_y, esc, pacman);
            }
            else{
                Random random = new Random();
                this.Direction = random.Next(1, 5);
            }
        }
    }
}
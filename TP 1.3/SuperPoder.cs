public class SuperPoder{
    #region  Atributos
    public bool Tipo;
    public int CantidadUsos;
    #endregion

    #region Constructor
    public SuperPoder(){
        this.Tipo = false;
        this.CantidadUsos = 0;
    }
    public SuperPoder(bool tipo, int usos){
        this.Tipo = tipo;
        this.CantidadUsos = usos;
    }
    #endregion

    #region Set & Get
    //Setters
    public void SetTipo(bool tipo){
        this.Tipo = tipo;
    }
    public void SetCantidadUsos(int usos){
        this.CantidadUsos = usos;
    }
    //Getters
    public bool GetTipo(){
        return this.Tipo;
    }
    public int GetCantidadUsos(){
        return this.CantidadUsos;
    }
    #endregion

    #region  Metodos
    public void UsarPoder(){
        this.CantidadUsos = this.CantidadUsos - 1;
    }
    #endregion
}
    
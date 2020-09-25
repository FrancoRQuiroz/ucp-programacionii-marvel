public class Juego{
    #region Atributos
    private bool Resultado;
    private int Nivel;
    private Combate Combate;
    #endregion

    #region  Constructor
    public Juego(){
        this.Resultado = false;
        this.Nivel = 0;
        this.Combate = new Combate();
    }
    public Juego(bool resultado, int nivel,Combate combate){
        this.Resultado = resultado;
        this.Nivel = nivel;
        this.Combate = combate;

    }
    #endregion

    #region  Set & Get
    public void SetResultado(bool resultado){
        this.Resultado = resultado;
    }
    public void SetNivel(int nivel){
        this.Nivel = nivel;
    }
    public void SetCombate(Combate combate){
        this.Combate = combate;
    }
    public bool GetResultado(){
        return this.Resultado;
    }
    public int GetNivel(){
        return this.Nivel;
    }
    public Combate GetCombate(){
        return this.Combate;
    }
    #endregion

    #region Metodos
    public void Comenzar(){

    }
    public void Terminar(){

    }
    #endregion
}
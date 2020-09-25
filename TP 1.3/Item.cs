public class Item{
    #region Atribtutos
    private string Tipo;
    #endregion

    #region Constructor
    public Item(){
        this.Tipo = "";
    }
    public Item(string tipo){
        this.Tipo = tipo;
    }
    #endregion

    #region Set & Get
    //Set
    public void SetTipoItem(string tipo){
        this.Tipo = tipo;
    }
    //Get
    public string GetTipoItem(){
        return this.Tipo;
    }
    #endregion

    #region  Metodos
    public void SortearItem(string tipo){
        this.Tipo = tipo;
    }
    #endregion
}
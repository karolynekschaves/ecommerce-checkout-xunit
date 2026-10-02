namespace EcommerceCheckout.Tests;

public class PedidoServiceTests
{
    private readonly EcommerceCheckout.App.PedidoService.PerfilJogadorService _service = new();

    [Fact]
    public void GerarCodigoRastreio_formataRegiaoENumeroPedido()
    {
        var resultado = _service.GerarCodigoRastreio("sudeste", 42);

        Assert.Equal("SUDESTE-0042", resultado);
    }

    [Fact]
    public void CalcularPontosFidelidade_calculaPontosCorretamente()
    {
        var resultado = _service.CalcularPontosFidelidade(150);

        Assert.Equal(30, resultado);
    }

    [Fact]
    public void TemDireitoAFreteGratis_retornaTrueParaClienteVipAbaixoDe200()
    {
        var resultado = _service.TemDireitoAFreteGratis(150, true);

        Assert.True(resultado);
    }

    [Fact]
    public void TemDireitoAFreteGratis_retornaFalseParaClienteNaoVipAbaixoDe200()
    {
        var resultado = _service.TemDireitoAFreteGratis(150, false);

        Assert.False(resultado);
    }
}
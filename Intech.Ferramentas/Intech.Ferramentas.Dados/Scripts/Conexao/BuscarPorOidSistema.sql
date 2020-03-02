/*Config
	RetornaLista
	Retorno
		-ConexaoEntidade
	Parametros
		-OID_SISTEMA:decimal
*/

SELECT *
FROM CONEXAO
WHERE OID_SISTEMA = @OID_SISTEMA
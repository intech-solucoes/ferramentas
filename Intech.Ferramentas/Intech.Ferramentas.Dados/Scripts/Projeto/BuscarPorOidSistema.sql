/*Config
	RetornaLista
	Retorno
		-ProjetoEntidade
	Parametros
		-OID_SISTEMA:decimal
*/

SELECT *
FROM PROJETO
WHERE OID_SISTEMA = @OID_SISTEMA
ORDER BY NOM_PROJETO
/*Config
	RetornaLista
	Retorno
		-DependenciaEntidade
	Parametros
		-OID_PROJETO:decimal
*/

SELECT *
FROM DEPENDENCIA
WHERE OID_PROJETO = @OID_PROJETO
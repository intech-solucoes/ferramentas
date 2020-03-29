import VersaoEntidade from "./VersaoEntidade";
import SistemaEntidade from "./SistemaEntidade";
import DependenciaEntidade from "./DependenciaEntidade";

export class ProjetoEntidade {
	public OID_PROJETO: number;
	public NOM_PROJETO: string;
	public IND_TIPO_PROJETO: string;
	public TXT_DIRETORIO: string;
	public TXT_NAMESPACE: string;
	public OID_SISTEMA: number;
	public OID_PROJETO_API?: number;
	public Versoes: Array<VersaoEntidade>;
	public Sistema: SistemaEntidade;
	public Dependencias: Array<DependenciaEntidade>;
}

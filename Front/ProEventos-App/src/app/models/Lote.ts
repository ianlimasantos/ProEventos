import { Palestrante } from "./Palestrante";

export interface Lote {

  id : number;
  nome : string;
  preco : number;
  dataInicio? : Date;
  dataFim?: Date;
  quantidade:number;
  eventoId: number;
  palestranteId?: number;
  palestrante : Palestrante;
}

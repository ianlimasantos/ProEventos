import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss'],
  // providers: [EventoService] forma de injeção de dependência
})
export class EventosComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

}

import { Component, OnInit, TemplateRef } from '@angular/core';

import { EventoService } from '../../services/evento.service';
import { Evento } from '../../models/Evento';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { ToastrService } from 'ngx-toastr';
import { NgxSpinnerService } from "ngx-spinner";

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

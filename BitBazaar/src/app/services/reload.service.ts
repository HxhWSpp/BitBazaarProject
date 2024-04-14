import { Injectable, EventEmitter } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ReloadService {
  reloadComponent: EventEmitter<any> = new EventEmitter();
  
  constructor() { }
}
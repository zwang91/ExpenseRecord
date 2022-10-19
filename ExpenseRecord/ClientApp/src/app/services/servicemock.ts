import { Injectable } from '@angular/core';
import { Observable, of, throwError } from 'rxjs';
import { v4 as uuidv4 } from 'uuid';
import { RecordItem } from '../models/RecordItem';

@Injectable({
  providedIn: 'root'
})
export class RecordMock {

  public displayList: Array<RecordItem> = new Array<RecordItem>;

  getAll(): RecordItem[] {
    return [
      {
        'id': '1',
        'description': 'lunch',
        'type': 'meal',
        'date': '2022-01-01',
        'amount': '500',

        
      },
      {
        'id': '2',
        'description': 'breakfast',
        'type': 'fruit',
        'date': '2022-01-01',
        'amount': '10',
      },
    ];
  }

  getOne(id: string, record: RecordItem[]): RecordItem | undefined {
    return record.find(t => t.id === id);
  }

  createOne(body: RecordItem, records: RecordItem[]): RecordItem {
    const record: RecordItem = {
      ...body,
      id: uuidv4(),
      date: new Date().toISOString()
    };
    records.push(record);
    return record;
  }

  deleteOne(id: string, todos: RecordItem[]): Observable<string> {
    const index: number = todos.findIndex(t => t.id === id);
    todos.splice(index, 1);
    this.write(todos);
    return of(id);
  }


  private write(items: RecordItem[]): void {
    localStorage.setItem('records', JSON.stringify(items));
  }
}

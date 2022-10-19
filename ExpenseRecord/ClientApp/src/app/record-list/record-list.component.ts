import { Component, OnInit, OnDestroy } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { RecordMock } from '../services/servicemock';
import { RecordItem } from '../models/RecordItem';

@Component({
  selector: 'app-record-list',
  templateUrl: './record-list.component.html',
  styleUrls: ['./record-list.component.scss']
})
export class RecordListComponent implements OnInit, OnDestroy{
  public searchString: string = '';
  public displayList: RecordItem[] = [];
  public sortByDateDir?: SortDir = SortDir.Asc;
  public SortDir = SortDir;
  public fullList: RecordItem[] = [];

  

  constructor(private record: RecordMock,  private router: Router, private route: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.loadData();
  }

  
  ngOnDestroy() {

  }

  reload(): void {
    this.searchString = "";
    this.loadData();
  }

  onSearchTextChange(text: string): void {
    this.searchString = text;
    this.displayList = this.searchString ? this.fullList.filter(i => i.description.toLowerCase().includes(this.searchString.toLowerCase())) : this.fullList.slice();
  }
  

  toggleSortByDate(): void {
    switch (this.sortByDateDir) {
      case SortDir.Asc:
        this.sortByDateDir = SortDir.Desc;
        break;
      case SortDir.Desc:
        this.sortByDateDir = undefined;
        break;
      default:
        this.sortByDateDir = SortDir.Asc;
    }
    this.record.displayList = [... this.record.displayList.sort((i1, i2) => (new Date(i1.date).getTime() - new Date(i2.date).getTime()) * (this.sortByDateDir === SortDir.Asc ? 1 : -1))];
  }

  CreateNew(){
    
  }
 

  private loadData(): void {
    this.displayList = this.getAll();
    this.fullList = [...this.displayList];
  }

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
}

enum SortDir {
  Asc = 1,
  Desc = 2
}

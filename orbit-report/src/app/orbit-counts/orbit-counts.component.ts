import { Component, OnInit, Input } from '@angular/core';
import {Satellite} from '../satellite';

@Component({
  selector: 'app-orbit-counts',
  templateUrl: './orbit-counts.component.html',
  styleUrls: ['./orbit-counts.component.css']
})
export class OrbitCountsComponent implements OnInit {
  @Input() satelliteList: Satellite[];
  satelliteTypes = ['space debris', 'communication', 'probe', 'positioning', 'space station', 'telescope'];
  satelliteCount : Satellite[] = [];

  constructor() { 
  }
  ngOnInit(){
  
  }
  
//   orbitCount(){
//     for (let i = 0; i < this.satelliteTypes.length; i++){
//       let type = this.satelliteTypes[i];
//       for(let j = 0; j < this.satelliteList.length; j++) {
//         let newType = this.satelliteList[j].type.toLowerCase();
//         if(type === newType ) {
//           this.satelliteCount[i] += 1;
//         }
//       }
//     }
//     return this.satelliteList;
//  } 

  orbitCount(){
    for (let i = 0; i < this.satelliteList.length; i++){
      let type = this.satelliteList[i].type; 
      this.satelliteList[i].count = 0; //make sure count attribute of the satellite object is zero
      let index = this.satelliteTypes.indexOf(type.toLowerCase()); //find the index of the current object type at satelliteTypes array

      if(index !== -1) { //if the current object type is in the satelliteTypes array
      this.satelliteCount.push(this.satelliteList[i]); //save the current object to satelliteCount array
      this.satelliteTypes.splice(index, 1); //remove the current object type from the satelliteTypes array to avoid multiple elements in the satelliteCount array
    }
      for(let j = 0; j < this.satelliteList.length; j++) {
        if(type === this.satelliteList[j].type) {
          this.satelliteList[i].count += 1;
        }
      }
    }
    
    return this.satelliteCount;
 } 

}

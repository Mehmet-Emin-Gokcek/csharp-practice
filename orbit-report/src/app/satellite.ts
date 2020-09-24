export class Satellite {
    name: string;
    orbitType: string;
    type: string;
    operational: boolean;
    launchDate: string;
    warning: boolean;
    count: number;

    constructor(name: string, type: string, launchDate: string, orbitType: string, operational: boolean) {
        this.name = name;
        this.orbitType = orbitType;
        this.type = type;
        this.operational = operational;
        this.launchDate = launchDate;
        this.warning = this.shouldShowWarning(type);
        this.count = 0;
    }
    shouldShowWarning(satelliteType: string): boolean{
        if (satelliteType.toUpperCase() === 'SPACE DEBRIS') {
            return true;
        }
        else {
            return false;
        }
    }

}

// This file can be replaced during build by using the `fileReplacements` array.
// `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.

export const environment = {
  production: false,
  apiUrl:'https://localhost:5001/api/',
  hubUrl:'https://localhost:5001/hubs/',
  docsUrl: 'https://localhost:5001/docs/',
  versionCheckURL: 'https://localhost:5003/auto-reload/',
  digitalProductGroupId:2,
  phisicalProductGroupId:1,

};

/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/plugins/zone-error';  // Included with Angular CLI.

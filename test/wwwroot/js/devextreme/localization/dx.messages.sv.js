/*!
* DevExtreme (dx.messages.sv.js)
* Version: 18.2.8
* Build date: Tue Apr 23 2019
*
* Copyright (c) 2012 - 2019 Developer Express Inc. ALL RIGHTS RESERVED
* Read about DevExtreme licensing here: https://js.devexpress.com/Licensing/
*/
"use strict";

! function(root, factory) {
    if ("function" === typeof define && define.amd) {
        define(function(require) {
            factory(require("devextreme/localization"))
        })
    } else {
        if ("object" === typeof module && module.exports) {
            factory(require("devextreme/localization"))
        } else {
            factory(DevExpress.localization)
        }
    }
}(this, function(localization) {
    localization.loadMessages({
        sv: {
            Yes: "Ja",
            No: "Nej",
            Cancel: "Avbryt",
            Clear: "Rensa",
            Done: "Klar",
            Loading: "Laddar...",
            Select: "V\xe4lj...",
            Search: "S\xf6k",
            Back: "Tillbaka",
            OK: "OK",
            "dxCollectionWidget-noDataText": "Inget data att visa",
            "validation-required": "Kr\xe4vs",
            "validation-required-formatted": "{0} kr\xe4vs",
            "validation-numeric": "V\xe4rdet m\xe5ste vara ett nummer",
            "validation-numeric-formatted": "{0} m\xe5ste vara ett nummer",
            "validation-range": "V\xe4rdet utanf\xf6r till\xe5tet intervall",
            "validation-range-formatted": "{0} utanf\xf6r till\xe5tet intervall",
            "validation-stringLength": "L\xe4ngden p\xe5 v\xe4rdet \xe4r inte korrekt",
            "validation-stringLength-formatted": "L\xe4ngden p\xe5  {0} \xe4r inte korrekt",
            "validation-custom": "Ogiltigt v\xe4rde",
            "validation-custom-formatted": "{0} \xe4r ogiltigt",
            "validation-compare": "V\xe4rdena matchar inte",
            "validation-compare-formatted": "{0} matchar inte",
            "validation-pattern": "V\xe4rdet matchar inte m\xf6nster",
            "validation-pattern-formatted": "{0} matchar inte m\xf6nster",
            "validation-email": "E-post \xe4r ogiltigt",
            "validation-email-formatted": "{0} \xe4r ogiltigt",
            "validation-mask": "V\xe4rdet \xe4r ogiltigt",
            "dxLookup-searchPlaceholder": "Minsta antal tecken: {0}",
            "dxList-pullingDownText": "Dra ner\xe5t f\xf6r att uppdatera...",
            "dxList-pulledDownText": "Sl\xe4pp f\xf6r att uppdatera...",
            "dxList-refreshingText": "Uppdaterar...",
            "dxList-pageLoadingText": "Laddar...",
            "dxList-nextButtonText": "Mer",
            "dxList-selectAll": "V\xe4lj alla",
            "dxListEditDecorator-delete": "Radera",
            "dxListEditDecorator-more": "Mer",
            "dxScrollView-pullingDownText": "Dra ner\xe5t f\xf6r att uppdatera...",
            "dxScrollView-pulledDownText": "Sl\xe4pp f\xf6r att uppdatera...",
            "dxScrollView-refreshingText": "uppdaterar...",
            "dxScrollView-reachBottomText": "Laddar...",
            "dxDateBox-simulatedDataPickerTitleTime": "V\xe4lj tid",
            "dxDateBox-simulatedDataPickerTitleDate": "V\xe4lj datum",
            "dxDateBox-simulatedDataPickerTitleDateTime": "V\xe4lj datum och tid",
            "dxDateBox-validation-datetime": "V\xe4rdet m\xe5ste vara ett datum eller en tid",
            "dxFileUploader-selectFile": "V\xe4lj fil",
            "dxFileUploader-dropFile": "eller sl\xe4pp filen h\xe4r",
            "dxFileUploader-bytes": "byte",
            "dxFileUploader-kb": "kb",
            "dxFileUploader-Mb": "Mb",
            "dxFileUploader-Gb": "Gb",
            "dxFileUploader-upload": "Ladda upp",
            "dxFileUploader-uploaded": "Uppladdad",
            "dxFileUploader-readyToUpload": "Klar att ladda upp",
            "dxFileUploader-uploadFailedMessage": "Uppladdning misslyckades",
            "dxFileUploader-invalidFileExtension": "",
            "dxFileUploader-invalidMaxFileSize": "",
            "dxFileUploader-invalidMinFileSize": "",
            "dxRangeSlider-ariaFrom": "Fr\xe5n",
            "dxRangeSlider-ariaTill": "Till",
            "dxSwitch-switchedOnText": "P\xc5",
            "dxSwitch-switchedOffText": "AV",
            "dxForm-optionalMark": "valfri",
            "dxForm-requiredMessage": "{0} \xe4r n\xf6dv\xe4ndigt",
            "dxNumberBox-invalidValueMessage": "V\xe4rdet m\xe5ste vara ett nummer",
            "dxDataGrid-columnChooserTitle": "Kolumnv\xe4ljare",
            "dxDataGrid-columnChooserEmptyText": "Dra en kolumn hit f\xf6r att d\xf6lja den",
            "dxDataGrid-groupContinuesMessage": "Forts\xe4tter p\xe5 n\xe4sta sida",
            "dxDataGrid-groupContinuedMessage": "Forts\xe4ttning fr\xe5n f\xf6reg\xe5ende sida",
            "dxDataGrid-groupHeaderText": "Gruppera enligt denna kolumn",
            "dxDataGrid-ungroupHeaderText": "Avgruppera",
            "dxDataGrid-ungroupAllText": "Avgruppera allt",
            "dxDataGrid-editingEditRow": "Redigera",
            "dxDataGrid-editingSaveRowChanges": "Spara",
            "dxDataGrid-editingCancelRowChanges": "Avbryt",
            "dxDataGrid-editingDeleteRow": "Radera",
            "dxDataGrid-editingUndeleteRow": "\xc5ngra radering",
            "dxDataGrid-editingConfirmDeleteMessage": "\xc4r du s\xe4ker p\xe5 att du vill radera denna post?",
            "dxDataGrid-validationCancelChanges": "Avbryt \xe4ndringarna",
            "dxDataGrid-groupPanelEmptyText": "Dra en kolumnrubrik hit f\xf6r att gruppera enligt den kolumnen",
            "dxDataGrid-noDataText": "Inget data",
            "dxDataGrid-searchPanelPlaceholder": "S\xf6k...",
            "dxDataGrid-filterRowShowAllText": "(Allt)",
            "dxDataGrid-filterRowResetOperationText": "\xc5terst\xe4ll",
            "dxDataGrid-filterRowOperationEquals": "\xc4r lika med",
            "dxDataGrid-filterRowOperationNotEquals": "\xc4r olika",
            "dxDataGrid-filterRowOperationLess": "Mindre \xe4n",
            "dxDataGrid-filterRowOperationLessOrEquals": "Mindre \xe4n eller lika med",
            "dxDataGrid-filterRowOperationGreater": "St\xf6rre \xe4n",
            "dxDataGrid-filterRowOperationGreaterOrEquals": "St\xf6rre \xe4n eller lika med",
            "dxDataGrid-filterRowOperationStartsWith": "B\xf6rjar med",
            "dxDataGrid-filterRowOperationContains": "Inneh\xe5ller",
            "dxDataGrid-filterRowOperationNotContains": "Inneh\xe5ller inte",
            "dxDataGrid-filterRowOperationEndsWith": "Slutar med",
            "dxDataGrid-filterRowOperationBetween": "Mellan",
            "dxDataGrid-filterRowOperationBetweenStartText": "Start",
            "dxDataGrid-filterRowOperationBetweenEndText": "Slut",
            "dxDataGrid-applyFilterText": "Anv\xe4nd filter",
            "dxDataGrid-trueText": "sant",
            "dxDataGrid-falseText": "falskt",
            "dxDataGrid-sortingAscendingText": "Sortera stigande",
            "dxDataGrid-sortingDescendingText": "Sortera fallande",
            "dxDataGrid-sortingClearText": "Rensa sortering",
            "dxDataGrid-editingSaveAllChanges": "Spara \xe4ndringar",
            "dxDataGrid-editingCancelAllChanges": "\xc5ngra \xe4ndringar",
            "dxDataGrid-editingAddRow": "L\xe4gg till rad",
            "dxDataGrid-summaryMin": "Min: {0}",
            "dxDataGrid-summaryMinOtherColumn": "Minimi av {1} \xe4r {0}",
            "dxDataGrid-summaryMax": "Max: {0}",
            "dxDataGrid-summaryMaxOtherColumn": "Maximi av {1} \xe4r {0}",
            "dxDataGrid-summaryAvg": "Medel: {0}",
            "dxDataGrid-summaryAvgOtherColumn": "Medeltal av {1} \xe4r {0}",
            "dxDataGrid-summarySum": "Sum: {0}",
            "dxDataGrid-summarySumOtherColumn": "Summan av {1} \xe4r {0}",
            "dxDataGrid-summaryCount": "Antal: {0}",
            "dxDataGrid-columnFixingFix": "Fixera",
            "dxDataGrid-columnFixingUnfix": "Avfixera",
            "dxDataGrid-columnFixingLeftPosition": "Till v\xe4nster",
            "dxDataGrid-columnFixingRightPosition": "Till h\xf6ger",
            "dxDataGrid-exportTo": "Exportera",
            "dxDataGrid-exportToExcel": "Exportera till Excel fil",
            "dxDataGrid-excelFormat": "Excel fil",
            "dxDataGrid-selectedRows": "Valda rader",
            "dxDataGrid-exportSelectedRows": "Exportera valda rader",
            "dxDataGrid-exportAll": "Exportera allt",
            "dxDataGrid-headerFilterEmptyValue": "(Tomma)",
            "dxDataGrid-headerFilterOK": "OK",
            "dxDataGrid-headerFilterCancel": "Avbryt",
            "dxDataGrid-ariaColumn": "Kolumn",
            "dxDataGrid-ariaValue": "V\xe4rde",
            "dxDataGrid-ariaFilterCell": "Filtrera cell",
            "dxDataGrid-ariaCollapse": "Kollapsa",
            "dxDataGrid-ariaExpand": "Expandera",
            "dxDataGrid-ariaDataGrid": "Datarutn\xe4t",
            "dxDataGrid-ariaSearchInGrid": "S\xf6k i datarutn\xe4tet",
            "dxDataGrid-ariaSelectAll": "V\xe4lj allt",
            "dxDataGrid-ariaSelectRow": "V\xe4lj rad",
            "dxDataGrid-filterBuilderPopupTitle": "Filterverktyg",
            "dxDataGrid-filterPanelCreateFilter": "Skapa filter",
            "dxDataGrid-filterPanelClearFilter": "Rensa",
            "dxDataGrid-filterPanelFilterEnabledHint": "Aktivera filter",
            "dxTreeList-ariaTreeList": "Tr\xe4dlista",
            "dxTreeList-editingAddRowToNode": "L\xe4gg till",
            "dxPager-infoText": "Sida {0} av {1} ({2} uppgifter)",
            "dxPager-pagesCountText": "av",
            "dxPivotGrid-grandTotal": "Totalsumma",
            "dxPivotGrid-total": "{0} Summa",
            "dxPivotGrid-fieldChooserTitle": "F\xe4ltv\xe4ljare",
            "dxPivotGrid-showFieldChooser": "Visa f\xe4ltv\xe4ljare",
            "dxPivotGrid-expandAll": "Expandera alla",
            "dxPivotGrid-collapseAll": "Kollapsa alla",
            "dxPivotGrid-sortColumnBySummary": 'Sortera "{0}" enligt denna kolumn',
            "dxPivotGrid-sortRowBySummary": 'Sortera "{0}" enligt denna rad',
            "dxPivotGrid-removeAllSorting": "Avl\xe4gsna all sortering",
            "dxPivotGrid-dataNotAvailable": "Saknas",
            "dxPivotGrid-rowFields": "Radf\xe4lt",
            "dxPivotGrid-columnFields": "Kolumnf\xe4lt",
            "dxPivotGrid-dataFields": "Dataf\xe4lt",
            "dxPivotGrid-filterFields": "Filterf\xe4lt",
            "dxPivotGrid-allFields": "Alla f\xe4lt",
            "dxPivotGrid-columnFieldArea": "Sl\xe4pp kolumnf\xe4lt h\xe4r",
            "dxPivotGrid-dataFieldArea": "Sl\xe4pp dataf\xe4lt h\xe4r",
            "dxPivotGrid-rowFieldArea": "Sl\xe4pp radf\xe4lt h\xe4r",
            "dxPivotGrid-filterFieldArea": "Sl\xe4pp filterf\xe4lt h\xe4r",
            "dxScheduler-editorLabelTitle": "\xc4mne",
            "dxScheduler-editorLabelStartDate": "Startdatum",
            "dxScheduler-editorLabelEndDate": "Slutdatum",
            "dxScheduler-editorLabelDescription": "Beskrivning",
            "dxScheduler-editorLabelRecurrence": "Upprepa",
            "dxScheduler-openAppointment": "\xd6ppna avtalad tid",
            "dxScheduler-recurrenceNever": "Aldrig",
            "dxScheduler-recurrenceDaily": "Varje dag",
            "dxScheduler-recurrenceWeekly": "Varje vecka",
            "dxScheduler-recurrenceMonthly": "Varje m\xe5nad",
            "dxScheduler-recurrenceYearly": "Varje \xe5r",
            "dxScheduler-recurrenceEvery": "Varje",
            "dxScheduler-recurrenceEnd": "Upprepning slutar",
            "dxScheduler-recurrenceAfter": "Efter",
            "dxScheduler-recurrenceOn": "P\xe5",
            "dxScheduler-recurrenceRepeatDaily": "dagar",
            "dxScheduler-recurrenceRepeatWeekly": "veckor",
            "dxScheduler-recurrenceRepeatMonthly": "m\xe5nader",
            "dxScheduler-recurrenceRepeatYearly": "\xe5r",
            "dxScheduler-switcherDay": "Dag",
            "dxScheduler-switcherWeek": "Vecka",
            "dxScheduler-switcherWorkWeek": "Arbetsvecka",
            "dxScheduler-switcherMonth": "M\xe5nad",
            "dxScheduler-switcherAgenda": "Agenda",
            "dxScheduler-switcherTimelineDay": "Tidslinje dag",
            "dxScheduler-switcherTimelineWeek": "Tidslinje vecka",
            "dxScheduler-switcherTimelineWorkWeek": "Tidslinje arbetsvecka",
            "dxScheduler-switcherTimelineMonth": "Tidslinje m\xe5nad",
            "dxScheduler-recurrenceRepeatOnDate": "p\xe5 datumet",
            "dxScheduler-recurrenceRepeatCount": "upprepning(ar)",
            "dxScheduler-allDay": "Hela dagen",
            "dxScheduler-confirmRecurrenceEditMessage": "Vill du redigera bara denna avtalade tid eller hela serien?",
            "dxScheduler-confirmRecurrenceDeleteMessage": "Vill du radera bara denna avtalade tid eller hela serien?",
            "dxScheduler-confirmRecurrenceEditSeries": "Redigera serien",
            "dxScheduler-confirmRecurrenceDeleteSeries": "Radera serien",
            "dxScheduler-confirmRecurrenceEditOccurrence": "Redigera avtalad tid",
            "dxScheduler-confirmRecurrenceDeleteOccurrence": "Radera avtalad tid",
            "dxScheduler-noTimezoneTitle": "Ingen tidszon",
            "dxScheduler-moreAppointments": "{0} mer",
            "dxCalendar-todayButtonText": "I dag",
            "dxCalendar-ariaWidgetName": "Kalender",
            "dxColorView-ariaRed": "R\xf6d",
            "dxColorView-ariaGreen": "Gr\xf6n",
            "dxColorView-ariaBlue": "Bl\xe5",
            "dxColorView-ariaAlpha": "Transparens",
            "dxColorView-ariaHex": "F\xe4rgkod",
            "dxTagBox-selected": "{0} valda",
            "dxTagBox-allSelected": "Alla valda ({0})",
            "dxTagBox-moreSelected": "{0} mer",
            "vizExport-printingButtonText": "Skriv ut",
            "vizExport-titleMenuText": "Export/Utskrift",
            "vizExport-exportButtonText": "{0} fil",
            "dxFilterBuilder-and": "Och",
            "dxFilterBuilder-or": "Eller",
            "dxFilterBuilder-notAnd": "Inte och",
            "dxFilterBuilder-notOr": "Inte eller",
            "dxFilterBuilder-addCondition": "L\xe4gg till villkor",
            "dxFilterBuilder-addGroup": "L\xe4gg till grupp",
            "dxFilterBuilder-enterValueText": "<ange v\xe4rde>",
            "dxFilterBuilder-filterOperationEquals": "\xc4r lika med",
            "dxFilterBuilder-filterOperationNotEquals": "\xc4r olika",
            "dxFilterBuilder-filterOperationLess": "Mindre \xe4n",
            "dxFilterBuilder-filterOperationLessOrEquals": "Mindre \xe4n eller lika med",
            "dxFilterBuilder-filterOperationGreater": "St\xf6rre \xe4n",
            "dxFilterBuilder-filterOperationGreaterOrEquals": "St\xf6rre \xe4n eller lika med",
            "dxFilterBuilder-filterOperationStartsWith": "B\xf6rjar med",
            "dxFilterBuilder-filterOperationContains": "Inneh\xe5ller",
            "dxFilterBuilder-filterOperationNotContains": "Inneh\xe5ller inte",
            "dxFilterBuilder-filterOperationEndsWith": "Slutar med",
            "dxFilterBuilder-filterOperationIsBlank": "\xc4r tom",
            "dxFilterBuilder-filterOperationIsNotBlank": "\xc4r inte tom",
            "dxFilterBuilder-filterOperationBetween": "Mellan",
            "dxFilterBuilder-filterOperationAnyOf": "N\xe5gon av",
            "dxFilterBuilder-filterOperationNoneOf": "Ingen av",
            "dxHtmlEditor-dialogColorCaption": "!TODO!",
            "dxHtmlEditor-dialogBackgroundCaption": "!TODO!",
            "dxHtmlEditor-dialogLinkCaption": "!TODO!",
            "dxHtmlEditor-dialogLinkUrlField": "!TODO!",
            "dxHtmlEditor-dialogLinkTextField": "!TODO!",
            "dxHtmlEditor-dialogLinkTargetField": "!TODO!",
            "dxHtmlEditor-dialogImageCaption": "!TODO!",
            "dxHtmlEditor-dialogImageUrlField": "!TODO!",
            "dxHtmlEditor-dialogImageAltField": "!TODO!",
            "dxHtmlEditor-dialogImageWidthField": "!TODO!",
            "dxHtmlEditor-dialogImageHeightField": "!TODO!",
            "dxHtmlEditor-heading": "!TODO!",
            "dxHtmlEditor-normalText": "!TODO!"
        }
    })
});

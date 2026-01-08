import {
  MAT_SELECT_CONFIG,
  MAT_SELECT_SCROLL_STRATEGY,
  MAT_SELECT_SCROLL_STRATEGY_PROVIDER,
  MAT_SELECT_SCROLL_STRATEGY_PROVIDER_FACTORY,
  MAT_SELECT_TRIGGER,
  MatSelect,
  MatSelectChange,
  MatSelectModule,
  MatSelectTrigger
} from "./chunk-WECYXBEW.js";
import "./chunk-ET2UBVYT.js";
import "./chunk-CRIX6Z7Q.js";
import {
  MatError,
  MatFormField,
  MatHint,
  MatLabel,
  MatPrefix,
  MatSuffix
} from "./chunk-XZ6W7M6E.js";
import "./chunk-OWIHQVW2.js";
import "./chunk-CPQ7OYUB.js";
import "./chunk-CTGJLU27.js";
import "./chunk-UVVSKXCV.js";
import "./chunk-NLIO2MZZ.js";
import {
  MatOptgroup,
  MatOption
} from "./chunk-PWTSYD2V.js";
import "./chunk-ZPNQNJYJ.js";
import "./chunk-FVTQOACS.js";
import "./chunk-5LRJWXF6.js";
import "./chunk-VENV3F3G.js";
import "./chunk-GWFLKVBH.js";
import "./chunk-7ZN4ENU7.js";
import "./chunk-QFHDPPWO.js";
import "./chunk-5RWELKZ3.js";
import "./chunk-6QYRZ3JF.js";
import "./chunk-5EG33CFQ.js";
import "./chunk-XOTRPSGG.js";
import "./chunk-K5AEVZX3.js";
import "./chunk-NQ6B5VN6.js";
import "./chunk-B5XAN7UP.js";
import "./chunk-JZ744EMP.js";
import "./chunk-CYIUJTKM.js";
import "./chunk-ZMRTNEEQ.js";
import "./chunk-KBUIKKCC.js";

// node_modules/@angular/material/fesm2022/select.mjs
var matSelectAnimations = {
  // Represents
  // trigger('transformPanel', [
  //   state(
  //     'void',
  //     style({
  //       opacity: 0,
  //       transform: 'scale(1, 0.8)',
  //     }),
  //   ),
  //   transition(
  //     'void => showing',
  //     animate(
  //       '120ms cubic-bezier(0, 0, 0.2, 1)',
  //       style({
  //         opacity: 1,
  //         transform: 'scale(1, 1)',
  //       }),
  //     ),
  //   ),
  //   transition('* => void', animate('100ms linear', style({opacity: 0}))),
  // ])
  /** This animation transforms the select's overlay panel on and off the page. */
  transformPanel: {
    type: 7,
    name: "transformPanel",
    definitions: [
      {
        type: 0,
        name: "void",
        styles: {
          type: 6,
          styles: { opacity: 0, transform: "scale(1, 0.8)" },
          offset: null
        }
      },
      {
        type: 1,
        expr: "void => showing",
        animation: {
          type: 4,
          styles: {
            type: 6,
            styles: { opacity: 1, transform: "scale(1, 1)" },
            offset: null
          },
          timings: "120ms cubic-bezier(0, 0, 0.2, 1)"
        },
        options: null
      },
      {
        type: 1,
        expr: "* => void",
        animation: {
          type: 4,
          styles: { type: 6, styles: { opacity: 0 }, offset: null },
          timings: "100ms linear"
        },
        options: null
      }
    ],
    options: {}
  }
};
export {
  MAT_SELECT_CONFIG,
  MAT_SELECT_SCROLL_STRATEGY,
  MAT_SELECT_SCROLL_STRATEGY_PROVIDER,
  MAT_SELECT_SCROLL_STRATEGY_PROVIDER_FACTORY,
  MAT_SELECT_TRIGGER,
  MatError,
  MatFormField,
  MatHint,
  MatLabel,
  MatOptgroup,
  MatOption,
  MatPrefix,
  MatSelect,
  MatSelectChange,
  MatSelectModule,
  MatSelectTrigger,
  MatSuffix,
  matSelectAnimations
};
//# sourceMappingURL=@angular_material_select.js.map

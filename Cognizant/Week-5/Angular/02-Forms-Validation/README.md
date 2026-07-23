# 02 - Forms & Validation

Demonstrates both Angular form approaches side by side.

## Template-Driven Form (`template-form`)
- `[(ngModel)]` binding on each field
- Validation via HTML attributes: `required`, `minlength`, `email`, `min`
- Per-field template reference variables (`#name="ngModel"`) to read validity/errors
- Submission handled through the `NgForm` reference (`#userForm="ngForm"`)

## Reactive Form (`reactive-form`)
- Built with `FormBuilder`: `FormGroup`, `FormControl`, and a `FormArray` for a dynamic list of phone numbers
- Built-in validators: `Validators.required`, `Validators.minLength`
- Custom validators: `strongPasswordValidator` (field-level) and `passwordsMatchValidator` (cross-field, group-level)
- Add/remove controls at runtime via `phoneNumbers.push()` / `removeAt()`

## Run
```bash
npm install
npm start
```

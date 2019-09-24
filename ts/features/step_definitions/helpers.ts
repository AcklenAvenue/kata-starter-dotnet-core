export function catchError(fn: Function) {
    try {
        fn();
        return false;
    } catch (error) {
        return error;
    }
}
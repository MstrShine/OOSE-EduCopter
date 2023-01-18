abstract class Criteria<T> {
  List<T> meetCriteria(List<T> listEntries);
}

//algemeen
class CombinedCriteria<T> implements Criteria<T> {
  List<Criteria<T>> criteriaList = [];

  CombinedCriteria({required this.criteriaList});

  @override
  List<T> meetCriteria(List<T> listEntries) {
    List<T> filteredList = listEntries;

    for (Criteria<T> criterium in criteriaList) {
        filteredList = criterium.meetCriteria(filteredList);
    }

    return filteredList;
  }
}
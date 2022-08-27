namespace FruitBowl {
	[System.Obsolete("Use Tuples instead")]
	public class Pair<T> {
		public T a;
		public T b;

		public Pair() {
			this.a = default(T);
			this.b = default(T);
		}

		public Pair(T first, T second) {
			a = first;
			b = second;
		}
	}

	[System.Obsolete("Use Tuples instead")]
	public class Pair<T, U> {
		public T a;
		public U b;

		public Pair() {
			this.a = default(T);
			this.b = default(U);
		}

		public Pair(T first, U second) {
			a = first;
			b = second;
		}
	}
}

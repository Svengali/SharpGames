

using System;


namespace game
{

	//	public record Teacher(string FirstName, string LastName, int Grade)
	//			: Person(FirstName, LastName);




	public class Tilemap<Tile>
	{
		public static int ChunkSide = 16;
		public static int ChunkSize = ChunkSide * ChunkSide;

		public record TMEntity(TMPos pos) : Entity<TMPos>(pos);

		public class TMChunk
		{
			ImmutableArray<TMEntity> tiles = new();


			public void set(TMPos pos)
			{
			}



		}

		public record struct TMPos(int x, int y, int z)
		{
			static TMPos From(TMChunkPos pos) => new TMPos(pos.x * ChunkSide, pos.y * ChunkSide, pos.z * ChunkSide);

		}

		public record struct TMChunkPos(int x, int y, int z)
		{
			static TMChunkPos From(TMPos pos) => new TMChunkPos(pos.x / ChunkSide, pos.y / ChunkSide, pos.z / ChunkSide);
		}









	}


	class TilemapViewTGui
	{




	}






}